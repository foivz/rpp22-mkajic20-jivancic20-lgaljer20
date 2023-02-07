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
using BusinessLogicLayer.Services;

namespace SmartBar
{
    public partial class UpravljanjeProizvodomForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly ProductService _productService = new ProductService();

        public UpravljanjeProizvodomForm()
        {
            InitializeComponent();
        }
        public UpravljanjeProizvodomForm(UpravljanjeInvantaromVM model)
        {
            InitializeComponent();
            txtName.Text = model.Name;
            txtPrice.Text = model.Price.ToString();
            txtAmount.Text = model.Amount.ToString();
            txtMinimum.Text = model.Minimum.ToString();
            txtOptimal.Text = model.Optimal.ToString();
            txtMeasurementUnit.Text = model.MeasurementUnit;
        }

        private void UpravljanjeProizvodomForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            try
            {
                product.Price = double.Parse(txtPrice.Text);
                product.Amount = int.Parse(txtAmount.Text);
                product.Minimum = int.Parse(txtMinimum.Text);
                product.Optimal = int.Parse(txtOptimal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Provjerite unesene brojeve", "", MessageBoxButtons.OK);
            }
            
            product.MeasurementUnit = txtMeasurementUnit.Text;
            product.UserId = 1; //treba maknut
            if (_productService.ValidateData(product))
            {
                _productRepository.CreateProduct(product);
                this.Close();
            }
            else
            {
                MessageBox.Show("Provjerite unos podataka!", "Unos podataka", MessageBoxButtons.OK);
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
