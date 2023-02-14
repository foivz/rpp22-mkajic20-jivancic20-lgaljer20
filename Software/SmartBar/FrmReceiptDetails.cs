using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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
        public string username { get; set; }
        public List<ReceiptListItem> items { get; set; }


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
            LoadData();
            DisplayData();
        }

        private void LoadData()
        {
            var service = new ReceiptService();
            username = service.GetReceiptUsername(receipt);
            items = service.GetReceiptItems(receipt);
        }

        private void DisplayData()
        {
            txtEmployee.Text = username;
            txtDate.Text = receipt.Date.ToString();
            txtPrice.Text = receipt.Price.ToString();
            txtPDV.Text = receipt.PDV.ToString();

            dgvReceiptItems.DataSource = items;

            dgvReceiptItems.Columns["Name"].HeaderText = "Proizvod";
            dgvReceiptItems.Columns["Price"].HeaderText = "Cijena";
            dgvReceiptItems.Columns["Amount"].HeaderText = "Količina";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var receiptReportForm = new ReceiptReportForm(receipt, items);
            receiptReportForm.ShowDialog();
        }
    }
}
