using DataAccessLayer.Repositories;
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
        private readonly OrderFormRepository _orderFormRepository = new OrderFormRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();
        public UpravljanjeStavkomNarudzbeniceForm()
        {
            InitializeComponent();
            cbProducts.DataSource = _productRepository.GetProducts().Select(x => x.Name).ToList();
            cbSuppliers.DataSource = _supplierRepository.GetSuppliers().Select(x => x.Name).ToList();
            cbProducts.SelectedItem = null;
            cbSuppliers.SelectedItem = null;
            dtpOrderDate.Value = DateTime.Now;
        }
        public UpravljanjeStavkomNarudzbeniceForm(UpravljanjeNarudzbenicamaVM model)
        {
            InitializeComponent();
            cbProducts.DataSource = _productRepository.GetProducts().Select(x => x.Name).ToList();
            cbSuppliers.DataSource = _supplierRepository.GetSuppliers().Select(x => x.Name).ToList();
            nudAmount.Value = (decimal)model.Amount;
            dtpOrderDate.Value = (DateTime)model.OrderDate;
            cbProducts.SelectedItem = null;
            cbSuppliers.SelectedItem = model.Supplier.Name;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
