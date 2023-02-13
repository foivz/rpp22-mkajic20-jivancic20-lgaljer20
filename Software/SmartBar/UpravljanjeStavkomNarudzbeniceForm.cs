using BusinessLogicLayer.Services;
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
    public partial class UpravljanjeStavkomNarudzbeniceForm : Form
    {
        SupplierService _supplierService = new SupplierService();
        OrderFormService _orderFormService = new OrderFormService();
        OrderItemService _orderItemService = new OrderItemService();
        ProductService _productService = new ProductService();

        List<KratkiProizvodVM> proizvodi = new List<KratkiProizvodVM>();

        private int orderFormId;
        public UpravljanjeStavkomNarudzbeniceForm()
        {
            InitializeComponent();
            cbProducts.DataSource = _productService.GetProducts().Select(x => x.Name).ToList();
            cbSuppliers.DataSource = _supplierService.GetSuppliers().Select(x => x.Name).ToList();
            cbProducts.SelectedItem = null;
            cbSuppliers.SelectedItem = null;
            dtpOrderDate.Value = DateTime.Now;
            dgvProducts.CellClick += dgvProducts_CellClick;
        }
        public UpravljanjeStavkomNarudzbeniceForm(UpravljanjeNarudzbenicamaVM model)
        {
            InitializeComponent();
            List<Product> products = _productService.GetProducts().ToList();

            cbProducts.DataSource = _productService.GetProducts().Select(x => x.Name).ToList();

            cbSuppliers.DataSource = _supplierService.GetSuppliers().Select(x => x.Name).ToList();

            if (model.Amount == null) model.Amount = 0;

            nudAmount.Value = (decimal)model.Amount;
            dtpOrderDate.Value = (DateTime)model.OrderDate;
            cbProducts.SelectedItem = null;
            cbSuppliers.SelectedItem = model.Supplier.Name;
            orderFormId = model.OrderFormId;
            dgvProducts.CellClick += dgvProducts_CellClick;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvProducts.Columns.Count - 1)
            {
                return;
            }

            KratkiProizvodVM proizvod = (KratkiProizvodVM)dgvProducts.Rows[e.RowIndex].DataBoundItem;

            DialogResult result = MessageBox.Show("Jeste li ste sigurni da želite obrisati ovaj proizvod?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                proizvodi.Remove(proizvod);

                RefreshGUI();
            }
        }
        private void RefreshGUI()
        {
            dgvProducts.Columns.Clear();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = proizvodi;
            dgvProducts.Refresh();

            while (dgvProducts.Columns.Count > 4)
            {
                dgvProducts.Columns.RemoveAt(4);
            }
            dgvProducts.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Izbriši",
                Width = 60,
                UseColumnTextForButtonValue = true
            });
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            KratkiProizvodVM kratkiProizvodVM = new KratkiProizvodVM();
            kratkiProizvodVM.Name = cbProducts.SelectedItem.ToString();
            kratkiProizvodVM.OrderAmount = (int)nudAmount.Value;

            string v = cbProducts.SelectedItem.ToString();
            Product v1 = _productService.GetProductByName(v);
            kratkiProizvodVM.Amount = v1.Amount;

            proizvodi.Add(kratkiProizvodVM);
            RefreshGUI();
        }

    }
}
