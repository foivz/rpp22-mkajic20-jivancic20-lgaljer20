using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using SmartBar.ViewModels;

namespace SmartBar
{
    public partial class UpravljanjeInventaromForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        public UpravljanjeInventaromForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void UpravljanjeInventaromForm_Load(object sender, EventArgs e)
        {
            List<UpravljanjeInvantaromVM> upravljanjeInvantaromVMs = new List<UpravljanjeInvantaromVM>();
            List<Product> products = _productRepository.GetProducts();
            foreach(Product product in products)
            {
                UpravljanjeInvantaromVM upravljanjeInvantaromVM = new UpravljanjeInvantaromVM
                {
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
        }
    }
}
