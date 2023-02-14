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
    public partial class FrmPopisPrimki : Form
    {
        private TestniService servis = new TestniService(); //servisi za OrderForm i OrderItem
        //servisNarudzbenica i servisStavkeNarudzbenice
        private DocketService servisiPrimke = new DocketService();
        private List<OrderItem> stavkeNarudzbenice = new List<OrderItem>();
        private DocketItemService docketServis = new DocketItemService();
        public FrmPopisPrimki()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmPopisPrimki_Load(object sender, EventArgs e)
        {
            PopuniNarudzbenice();
        }

        private void PopuniNarudzbenice()
        {
            dgNarudzbenice.DataSource = servis.GetAllNarudzbenice();
            dgNarudzbenice.Columns[4].Visible = false;
            dgNarudzbenice.Columns[5].Visible = false;
            dgNarudzbenice.Columns[6].Visible = false;
        }

        private void btnRučno_Click(object sender, EventArgs e)
        {
            var forma = new FrmPrimka();
            forma.ShowDialog();


        }

        private void btnAutomatski_Click(object sender, EventArgs e)
        {
            KreirajAutomatskiPrimku();
        }
        private void KreirajAutomatskiPrimku()
        {
            OrderForm selektiranaNarudzbenica = dgNarudzbenice.CurrentRow.DataBoundItem as OrderForm;
            Docket newDocket = new Docket
            {
                Date = DateTime.Now,
                UserId = 1, //CurrentUser.user.Id,
                SupplierId = selektiranaNarudzbenica.SupplierId,    

            };
            servisiPrimke.AddDocket(newDocket);
            ObradiKreiranje(selektiranaNarudzbenica.Id, newDocket.Id);
   
          

        }

        private void ObradiKreiranje(int idNarudzbenice, int idPrimke)
        {
            stavkeNarudzbenice = servis.GetOrderItems(idNarudzbenice);

            foreach (var stavka in stavkeNarudzbenice)
            {
                DocketItem newStavka = new DocketItem
                {
                    DocketId = idPrimke,
                    Amount = (int)stavka.Amount,
                    ProductId = stavka.ProductId,
                };

                docketServis.AddDocketItem(newStavka);
            }
        }


    }
}
