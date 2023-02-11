using BusinessLogicLayer.Services;
using DataAccessLayer;
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
    public partial class FrmPopisIzvjestaja : Form
    {
        private InventoryRecordService servisi= new InventoryRecordService();
        public FrmPopisIzvjestaja()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmPopisIzvjestaja_Load(object sender, EventArgs e)
        {
            UcitajIzvjestaj();
        }

        private void UcitajIzvjestaj()
        {
            var izvjestaji =  servisi.GetAllRecords();
            dgIzvjestaji.DataSource = izvjestaji.ToList();
            dgIzvjestaji.Columns[3].Visible = false;
            dgIzvjestaji.Columns[4].Visible = false;

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            InventoryRecord selectedRecord = dgIzvjestaji.CurrentRow.DataBoundItem as InventoryRecord;
            if (selectedRecord != null)
            {
                var form = new Izvjestaj(selectedRecord.Id);
                form.ShowDialog();


            }
            else
            {
                MessageBox.Show("Morate izabrati izvještaj za pregled!");
            }
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            var form = new FrmIzvjestajInventurniZapisnik();
            form.ShowDialog();

            UcitajIzvjestaj();
        }
    }
}
