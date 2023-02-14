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
    public partial class FrmPopisPrimki : Form
    {
       // private TestniService servis = new TestniService(); //servisi za OrderForm i OrderItem
        //servisNarudzbenica i servisStavkeNarudzbenice
        private OrderFormService servisNarudzbenica = new OrderFormService();
        private OrderItemService servisStavkeNarudzbenice = new OrderItemService();
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
            helpProvider1.HelpNamespace = System.Windows.Forms.Application.StartupPath + "\\Chm files/PopisPrimki.chm";
            PopuniNarudzbenice();
        }

        private void PopuniNarudzbenice()
        {
           
           //dgNarudzbenice.DataSource = servisNarudzbenica.GetOrderForms();
            dgNarudzbenice.DataSource = servisNarudzbenica.GetAllOrders();
            
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
                UserId = CurrentUser.user.Id,
                SupplierId = selektiranaNarudzbenica.SupplierId,    

            };
            servisiPrimke.AddDocket(newDocket);
            ObradiKreiranje(selektiranaNarudzbenica.Id, newDocket.Id);

            var forma = new FrmPrimka();
            forma.ShowDialog();

        }

        private void ObradiKreiranje(int idNarudzbenice, int idPrimke)
        {
            stavkeNarudzbenice = servisStavkeNarudzbenice.GetOrderItemsById(idNarudzbenice);

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
