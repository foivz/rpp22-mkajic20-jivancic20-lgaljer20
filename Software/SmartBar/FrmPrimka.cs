using BusinessLogicLayer;
using BusinessLogicLayer.Services;
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
    public partial class FrmPrimka : Form
    {
        private DocketService servisiPrimke = new DocketService();
        private DocketItemService servisiStavkePrimke = new DocketItemService();
        public FrmPrimka()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmPrimka_Load(object sender, EventArgs e)
        {
            OsvjeziPrimke();
            OsvjeziStavke();
           
        }

        private void OsvjeziStavke()
        {
            var primka = dohvatiSelektiranuPrimku();
            if(primka != null)
            {
                dgvStavkePrimke.DataSource = servisiStavkePrimke.GetDocketsById(primka.Id);
                dgvStavkePrimke.Columns[3].Visible = false;
               
            }
          
           
        }

        private void OsvjeziPrimke()
        {

            dgvPrimke.DataSource = servisiPrimke.GetAllDockets();
            dgvPrimke.Columns[4].Visible = false;
            dgvPrimke.Columns[5].Visible = false;
            dgvPrimke.Columns[6].Visible = false;
        }

        private void btnNovaPrimka_Click(object sender, EventArgs e)
        {
            KreirajDocket();

        }

        private void KreirajDocket()
        {
            Docket newDocket = new Docket
            {
                Date = DateTime.Now,
                UserId = 1, //CurrentUser.user.Id,
                SupplierId = 1 // dohvatit suppliere u combobox i onda dodat

            };
            servisiPrimke.AddDocket(newDocket);

            OsvjeziPrimke();
        }

        private void btnIzbrišiPrimku_Click(object sender, EventArgs e)
        {
            IzbrišiDocket();
        }

        private Docket dohvatiSelektiranuPrimku()
        {
            return dgvPrimke.CurrentRow.DataBoundItem as Docket;
        }

        private void IzbrišiDocket()
        {
            Docket docket = dohvatiSelektiranuPrimku();
            if (docket != null)
            {
                bool uspjesno = servisiPrimke.RemoveDocket(docket);
                if (uspjesno == false)
                {
                    MessageBox.Show("Primka sadrži stavke i ne može se izbrisati");
                }
                else
                {
                    OsvjeziPrimke();
                }
                
            }
        }

        private void dgvPrimke_SelectionChanged(object sender, EventArgs e)
        {
            OsvjeziStavke();
        }

        private void btnAddStavka_Click(object sender, EventArgs e)
        {
            Docket docket = dohvatiSelektiranuPrimku();
            var forma = new FrmNovaStavkaPrimke(docket);
            forma.ShowDialog();

            OsvjeziStavke();
        }

        private void btnDeleteStavka_Click(object sender, EventArgs e)
        {

        }
    }
}
