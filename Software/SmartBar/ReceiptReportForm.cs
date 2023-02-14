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
    public partial class ReceiptReportForm : Form
    {
        private Receipt receipt;
        private List<ReceiptListItem> items;

        public ReceiptReportForm(Receipt receipt, List<ReceiptListItem> items)
        {
            this.receipt = receipt;
            this.items = items;
            InitializeComponent();
        }

        private void ReceiptReportForm_Load(object sender, EventArgs e)
        {
            //this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
            receiptBindingSource.DataSource = receipt;
            receiptListItemBindingSource.DataSource = items;
        }
    }
}
