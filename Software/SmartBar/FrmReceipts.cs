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
    public partial class FrmReceipts : Form
    {
        public ReceiptService Service { get; set; }
        public FrmReceipts()
        {
            InitializeComponent();
            Service = new ReceiptService();
        }

        private void FrmReceipts_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI() 
        {
            dgvReceipts.DataSource = Service.GetAllReceipts();
            dgvReceipts.Columns["User"].Visible = false;
            dgvReceipts.Columns["ReceiptItems"].Visible = false;
        }
    }
}
