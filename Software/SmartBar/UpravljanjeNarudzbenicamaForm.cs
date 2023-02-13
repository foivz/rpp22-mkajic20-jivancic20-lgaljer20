using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using SmartBar.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartBar
{
    public partial class UpravljanjeNarudzbenicamaForm : Form
    {
        SupplierService _supplierService = new SupplierService();
        OrderFormService _orderFormService = new OrderFormService();
        OrderItemService _orderItemService = new OrderItemService();
        ProductService _productService = new ProductService();

        public UpravljanjeNarudzbenicamaForm()
        {
            InitializeComponent();
            //dgvNarudzbenice.CellClick += dgvNarudzbenice_CellClick;
        }

        private void dgvNarudzbenice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = sender.ToString();
            if (e.ColumnIndex == 4)
            {       
                NarudzbenicaVM upravljanjeInvantaromVM = (NarudzbenicaVM)dgvNarudzbenice.Rows[e.RowIndex].DataBoundItem;
                OrderForm orderForm = _orderFormService.GetOrderFormById(upravljanjeInvantaromVM.Id);
                UpravljanjeNarudzbenicamaVM upravljanjeNarudzbenicamaVM = new UpravljanjeNarudzbenicamaVM
                {
                    OrderFormId = orderForm.Id,
                    OrderDate = orderForm.Date,
                    
                    Supplier = _supplierService.GetSupplierById(orderForm.Id),
                    OrderItems = _orderItemService.GetOrderItemsById(orderForm.Id),
                    //User = _userService.GetUserById(orderForm.Id)

                };
                UpravljanjeStavkomNarudzbeniceForm upravljanjeStavkomNarudzbenice = new UpravljanjeStavkomNarudzbeniceForm(upravljanjeNarudzbenicamaVM);
                upravljanjeStavkomNarudzbenice.ShowDialog();
                RefreshGUI();
            }
            else if (e.ColumnIndex == 5)
            {
                NarudzbenicaVM upravljanjeInvantaromVM = (NarudzbenicaVM)dgvNarudzbenice.Rows[e.RowIndex].DataBoundItem;
                OrderForm orderForm = _orderFormService.GetOrderFormById(upravljanjeInvantaromVM.Id);
                
                DialogResult result = MessageBox.Show("Jeste li ste sigurni da želite obrisati ovu narudžbenicu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _orderFormService.DeleteOrderForm(orderForm.Id);
                    RefreshGUI();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else if(e.ColumnIndex == 6)
            {
                NarudzbenicaVM upravljanjeInvantaromVM = (NarudzbenicaVM)dgvNarudzbenice.Rows[e.RowIndex].DataBoundItem;
                OrderForm orderForm = _orderFormService.GetOrderFormById(upravljanjeInvantaromVM.Id);
                List<OrderItem> orderItems = _orderItemService.GetOrderItems();
                List<OrderItem> orderItems1 = new List<OrderItem>();
                foreach (OrderItem orderItem in orderItems)
                {
                    if (orderItem.OrderFormId == orderForm.Id)
                    {
                        orderItem.Product = _productService.GetProductById(orderItem.ProductId);
                        orderItems1.Add(orderItem);
                    }
                }

                NarudzbenicaReport report = new NarudzbenicaReport(orderForm,orderItems1);
                report.Show();
                

            }

        }

        private void UpravljanjeNarudzbenicamaForm_Load(object sender, EventArgs e)
        {

            RefreshGUI();

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            UpravljanjeStavkomNarudzbeniceForm stavka = new UpravljanjeStavkomNarudzbeniceForm();
            stavka.ShowDialog();
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            dgvNarudzbenice.Columns.Clear();
            List<NarudzbenicaVM> upravljanjeInvantaromVMs = new List<NarudzbenicaVM>();
            List<OrderForm> products = _orderFormService.GetOrderForms();
            foreach (OrderForm product in products)
            {
                NarudzbenicaVM upravljanjeInvantaromVM = new NarudzbenicaVM
                {
                    Id = product.Id,
                    UserName = "Mirko", //maknut ime, dodat dohvacanje imena
                    SupplierName = product.Supplier.Name,
                    OrderDate = product.Date
                    
                };
                upravljanjeInvantaromVMs.Add(upravljanjeInvantaromVM);
            }
            dgvNarudzbenice.DataSource = upravljanjeInvantaromVMs;
            string test = dgvNarudzbenice.Columns.Count.ToString();
            
            while (dgvNarudzbenice.Columns.Count > 5)
            {
                string v1 = dgvNarudzbenice.Columns.Count.ToString();
                dgvNarudzbenice.Columns.RemoveAt(5);
            }

            dgvNarudzbenice.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Uredi",
                Width = 60,
                UseColumnTextForButtonValue = true
            });
            
            dgvNarudzbenice.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Izbriši",
                Width = 60,
                UseColumnTextForButtonValue = true
            });

            dgvNarudzbenice.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Ispiši",
                Width = 60,
                UseColumnTextForButtonValue = true
            });

        }

    }
}
