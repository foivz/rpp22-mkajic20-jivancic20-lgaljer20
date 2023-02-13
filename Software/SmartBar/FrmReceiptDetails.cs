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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartBar
{
    public partial class FrmReceiptDetails : Form
    {
        public Receipt receipt { get; set; }
        public FrmReceiptDetails(Receipt r)
        {
            InitializeComponent();
            receipt = r;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frmReceipts = new FrmReceipts();
            Hide();
            frmReceipts.ShowDialog();
            Close();
        }

        private void FrmReceiptDetails_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            var service = new ReceiptService();
            txtEmployee.Text = service.GetReceiptUsername(receipt);
            txtDate.Text = receipt.Date.ToString();
            txtPrice.Text = receipt.Price.ToString();
            txtPDV.Text = receipt.PDV.ToString();

            List<ReceiptListItem> items = new List<ReceiptListItem>();
            items = service.GetReceiptItems(receipt);

            dgvReceiptItems.DataSource = items;

            dgvReceiptItems.Columns["Name"].HeaderText = "Proizvod";
            dgvReceiptItems.Columns["Price"].HeaderText = "Cijena";
            dgvReceiptItems.Columns["Amount"].HeaderText = "Količina";
        }
    }
}
