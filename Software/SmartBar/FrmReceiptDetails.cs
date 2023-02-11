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
    public partial class FrmReceiptDetails : Form
    {
        public FrmReceiptDetails(Receipt receipt)
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frmReceipts = new FrmReceipts();
            Hide();
            frmReceipts.ShowDialog();
            Close();
        }
    }
}
