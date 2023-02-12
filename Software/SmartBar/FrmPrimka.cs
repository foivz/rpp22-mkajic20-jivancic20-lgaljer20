using BusinessLogicLayer.Services;
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
        public FrmPrimka()
        {
            InitializeComponent();
        }

        private void FrmPrimka_Load(object sender, EventArgs e)
        {
            DohvatiPrimke();
        }

        private void DohvatiPrimke()
        {
            
            dgvPrimke.DataSource = servisiPrimke.GetAllDockets();
            dgvPrimke.Columns[4].Visible = false;
            dgvPrimke.Columns[5].Visible = false;
            dgvPrimke.Columns[6].Visible = false;
        }

        private void btnNovaPrimka_Click(object sender, EventArgs e)
        {

        }
    }
}
