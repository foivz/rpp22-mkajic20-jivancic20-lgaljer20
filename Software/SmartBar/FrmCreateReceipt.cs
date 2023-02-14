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
    public partial class FrmCreateReceipt : Form
    {
        public FrmCreateReceipt()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmAddReceiptItem = new FrmAddReceiptItem();
            frmAddReceiptItem.ShowDialog();
            LoadItems();
        }

        private void LoadItems()
        {
            List<AddReceiptItem> list = CreateReceiptService.GetAddedItems();
            dgvItems.DataSource = null;
            dgvItems.DataSource = list;

            txtPrice.Text = CreateReceiptService.GetTotalPrice().ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frmReceipts = new FrmReceipts();
            Hide();
            frmReceipts.ShowDialog();
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //TODO kreiraj racun
            var frmReceipts = new FrmReceipts();
            Hide();
            frmReceipts.ShowDialog();
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dgvItems.SelectedCells.Count == 0) 
            {
                MessageBox.Show("Niste odabrali račun.");
            } 
            else
            {
                int selectedRowIndex = dgvItems.SelectedCells[0].RowIndex;
                AddReceiptItem selectedItem = (AddReceiptItem)dgvItems.Rows[selectedRowIndex].DataBoundItem;
                CreateReceiptService.RemoveItem(selectedItem);
                LoadItems();
            }
        }
    }
}
