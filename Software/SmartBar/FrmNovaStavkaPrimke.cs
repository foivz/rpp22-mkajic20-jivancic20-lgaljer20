using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBar
{
    public partial class FrmNovaStavkaPrimke : Form
    {
        private Docket selectedDocket;

        ProductRepository repo = new ProductRepository();
        public FrmNovaStavkaPrimke(Docket docket)
        {
            InitializeComponent();
            selectedDocket = docket;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void FrmNovaStavkaPrimke_Load(object sender, EventArgs e)
        {
            DohvatiProizvode();
        }

        private void DohvatiProizvode()
        {
            cmbProizvodi.DataSource = repo.GetProducts();
        }
    }
}
