using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using SmartBar.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartBar
{
    public partial class UpravljanjeNarudzbenicamaForm : Form
    {
        private readonly OrderFormRepository _orderFormRepository = new OrderFormRepository();

        public UpravljanjeNarudzbenicamaForm()
        {
            InitializeComponent();
            dgvNarudzbenice.CellClick += dgvNarudzbenice_CellClick;
        }

        private void dgvNarudzbenice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                UpravljanjeNarudzbenicamaVM upravljanjeInvantaromVM = (UpravljanjeNarudzbenicamaVM)dgvNarudzbenice.Rows[e.RowIndex].DataBoundItem;
                UpravljanjeStavkomNarudzbeniceForm upravljanjeStavkomNarudzbenice = new UpravljanjeProizvodomForm(upravljanjeInvantaromVM);
                upravljanjeStavkomNarudzbenice.ShowDialog();
                RefreshGUI();
            }
            else if (e.ColumnIndex == 6)
            {
                UpravljanjeNarudzbenicamaVM product = (UpravljanjeNarudzbenicamaVM)dgvNarudzbenice.Rows[e.RowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Jeste li ste sigurni da želite da obrišete ovaj proizvod?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _orderFormRepository.DeleteOrderForm(product.Id);
                    RefreshGUI();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }

        }

        private void UpravljanjeNarudzbenicamaForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            dgvNarudzbenice.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Uredi",
                Width = 60,
                UseColumnTextForButtonValue = true
            });
            dgvNarudzbenice.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Izbriši",
                Width = 60,
                UseColumnTextForButtonValue = true
            });
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            UpravljanjeStavkomNarudzbeniceForm stavka = new UpravljanjeStavkomNarudzbeniceForm();
            stavka.ShowDialog();
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            List<NarudzbenicaVM> upravljanjeInvantaromVMs = new List<NarudzbenicaVM>();
            List<OrderForm> products = _orderFormRepository.GetOrderForms();
            foreach (OrderForm product in products)
            {
                NarudzbenicaVM upravljanjeInvantaromVM = new NarudzbenicaVM
                {
                    Id = product.Id,
                    UserName = "Mirko", //maknut ime, dodat dohvacanje imena
                    SupplierName = product.Supplier.Name,
                    OrderDate = product.Date
                    
                };
                upravljanjeInvantaromVMs.Add(upravljanjeInvantaromVM);
            }
            dgvNarudzbenice.DataSource = upravljanjeInvantaromVMs;
        }
    }
}
