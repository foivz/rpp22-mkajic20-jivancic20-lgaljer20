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
    public partial class NarudzbenicaReport : Form
    {
        SupplierService _supplierService = new SupplierService();
        OrderFormService _orderFormService = new OrderFormService();
        OrderItemService _orderItemService = new OrderItemService();
        ProductService _productService = new ProductService();
        UserService _userService = new UserService();
        public NarudzbenicaReport(OrderForm orderForm, List<OrderItem> orderItems)
        {
            InitializeComponent();
            orderForm.User = _userService.GetUserById(orderForm.UserId);
            OrderFormBindingSource.DataSource = orderForm;
            OrderItemBindingSource.DataSource = orderItems;
            List<Product> products = _productService.GetProducts();
            List<Product> products1 = new List<Product>();
            foreach (var orderItem in orderItems)
            {
                foreach (var product in products)
                {
                    if (product.Id == orderItem.ProductId)
                    {
                        products1.Add(product);
                    }
                }
            }
            

            productBindingSource.DataSource = products1;
            userBindingSource.DataSource = orderForm.User;
            supplierBindingSource.DataSource = orderForm.Supplier;

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("OrderForm", OrderFormBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("OrderItem", OrderItemBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Product", productBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("User", userBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Supplier", supplierBindingSource));

            reportViewer1.RefreshReport();
        }
        private void NarudzbenicaReport_Load(object sender, EventArgs e)
        {

            reportViewer1.RefreshReport();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
