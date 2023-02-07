using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using SmartBar.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartBar
{
    public partial class UpravljanjeInventaromForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();


        public UpravljanjeInventaromForm()
        {
            InitializeComponent();
            dgvInventar.CellClick += dgvInventar_CellClick;
        }
       
       
        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
        private void dgvInventar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                UpravljanjeInvantaromVM upravljanjeInvantaromVM = (UpravljanjeInvantaromVM)dgvInventar.Rows[e.RowIndex].DataBoundItem;
                UpravljanjeInventaromForm upravljanjeInventaromForm = new UpravljanjeInventaromForm();
                upravljanjeInventaromForm.Show();
            }
            else if (e.ColumnIndex == 8)
            {
                UpravljanjeInvantaromVM product = (UpravljanjeInvantaromVM)dgvInventar.Rows[e.RowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Jeste li ste sigurni da želite da obrišete ovaj proizvod?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {
                    _productRepository.DeleteProduct(product.Id);
                    //dgvInventar.Rows.RemoveAt(e.RowIndex);
                    UpravljanjeInventaromForm_Load(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            
        }
        
        private void UpravljanjeInventaromForm_Load(object sender, EventArgs e)
        {
            List<UpravljanjeInvantaromVM> upravljanjeInvantaromVMs = new List<UpravljanjeInvantaromVM>();
            List<Product> products = _productRepository.GetProducts();
            foreach(Product product in products)
            {
                UpravljanjeInvantaromVM upravljanjeInvantaromVM = new UpravljanjeInvantaromVM
                {
                    Id = product.Id,
                    Price = product.Price,
                    Name = product.Name,
                    Amount = product.Amount,
                    Minimum = product.Minimum,
                    Optimal = product.Optimal,
                    MeasurementUnit = product.MeasurementUnit
                };
                upravljanjeInvantaromVMs.Add(upravljanjeInvantaromVM);
            }
            dgvInventar.DataSource = upravljanjeInvantaromVMs;
            dgvInventar.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Uredi",
                Width = 60,
                UseColumnTextForButtonValue = true
            });
            dgvInventar.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Izbriši",
                Width = 60,
                UseColumnTextForButtonValue = true
            });
        }
    }
}
