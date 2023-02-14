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
    public partial class FrmAddReceiptItem : Form
    {
        public List<Product> Products { get; set; }
        public ReceiptService Service { get; set; }
       
        public FrmAddReceiptItem()
        {
            InitializeComponent();
        }

        private void FrmAddReceiptItem_Load(object sender, EventArgs e)
        {
            Service = new ReceiptService();
            Products = Service.GetAllProducts();

            PopulateCombo();
        }

        private void PopulateCombo()
        {
            foreach (Product product in Products)
            {
                cbProducts.Items.Add(product.Name);
            }
            
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbProducts.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Product selectedProduct = Products[selectedIndex];
                txtMaxAmount.Text = selectedProduct.Amount.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbProducts.SelectedItem == null || txtAmount.Text.Length == 0)
            {
                MessageBox.Show("Ispunite sva polja");
                return;
            }

            int amount;
            if (int.TryParse(txtAmount.Text, out amount))
            {
                int selectedIndex = cbProducts.SelectedIndex;
                Product selectedProduct = Products[selectedIndex];
                if(selectedProduct.Amount < amount)
                {
                    MessageBox.Show("Neispravna količina");
                    return;
                }

                CreateReceiptService.AddReceiptItem(selectedProduct, amount);
                Close();
            }
            else
            {
                MessageBox.Show("Unesena količina mora biti broj.");
            }       
        }
    }
}
