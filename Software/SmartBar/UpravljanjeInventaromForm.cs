using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using SmartBar.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogicLayer.Services;
using System.Drawing;
using BusinessLogicLayer;

namespace SmartBar
{
    public partial class UpravljanjeInventaromForm : Form
    {
        SupplierService _supplierService = new SupplierService();
        OrderFormService _orderFormService = new OrderFormService();
        OrderItemService _orderItemService = new OrderItemService();
        ProductService _productService = new ProductService();
        public UpravljanjeInventaromForm()
        {
            InitializeComponent();
            dgvInventar.CellClick += dgvInventar_CellClick;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            UpravljanjeProizvodomForm upravljanjeInventaromForm = new UpravljanjeProizvodomForm();
            upravljanjeInventaromForm.ShowDialog();
            RefreshGUI();
        }

        private void dgvInventar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                UpravljanjeInvantaromVM upravljanjeInvantaromVM = (UpravljanjeInvantaromVM)dgvInventar.Rows[e.RowIndex].DataBoundItem;
                UpravljanjeProizvodomForm upravljanjeInventaromForm = new UpravljanjeProizvodomForm(upravljanjeInvantaromVM);
                upravljanjeInventaromForm.ShowDialog();
                RefreshGUI();
            }
            else if (e.ColumnIndex == 8)
            {
                UpravljanjeInvantaromVM product = (UpravljanjeInvantaromVM)dgvInventar.Rows[e.RowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Jeste li ste sigurni da želite obrisati ovaj proizvod?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _productService.DeleteProduct(product.Id);
                    RefreshGUI();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }

        }

        private void RefreshGUI()
        {
            dgvInventar.Columns.Clear();
            List<UpravljanjeInvantaromVM> upravljanjeInvantaromVMs = new List<UpravljanjeInvantaromVM>();
            List<Product> products = _productService.GetProducts();
            foreach (Product product in products)
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

            while (dgvInventar.Columns.Count > 7)
            {
                string v1 = dgvInventar.Columns.Count.ToString();
                dgvInventar.Columns.RemoveAt(7);
            }
            foreach (DataGridViewRow item in dgvInventar.Rows)
            {
                if (Convert.ToInt32(item.Cells[3].Value) < Convert.ToInt32(item.Cells[4].Value))
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(item.Cells[3].Value) < Convert.ToInt32(item.Cells[5].Value))
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }

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

            dgvInventar.Columns[0].Visible = false;
        }

        private void UpravljanjeInventaromForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void btnLowProduct_Click(object sender, EventArgs e)
        {

            List<KratkiProizvodVM> kratkiProizvodi = new List<KratkiProizvodVM>();
            List<Product> products = _productService.GetProducts();
            foreach (Product product in products)
            {
                if (product.Amount < product.Minimum)
                {
                    KratkiProizvodVM upravljanjeInvantaromVM = new KratkiProizvodVM
                    {
                        Name = product.Name,
                        Amount = product.Amount,
                        OrderAmount = product.Optimal - product.Amount,
                        

                    };
                    kratkiProizvodi.Add(upravljanjeInvantaromVM);

                }
            }
            
            
            
            UpravljanjeStavkomNarudzbeniceForm narudzbenicaForm = new UpravljanjeStavkomNarudzbeniceForm(kratkiProizvodi);
            narudzbenicaForm.ShowDialog();
            RefreshGUI();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();
            int role = loginService.CheckUserRole();

            if (role == 1)
            {
                var frmUser = new FrmUser();
                Hide();
                frmUser.ShowDialog();
                Close();
            }
            else
            {
                var frmAdmin = new FrmAdmin();
                Hide();
                frmAdmin.ShowDialog();
                Close();
            }

        }
    }
}
