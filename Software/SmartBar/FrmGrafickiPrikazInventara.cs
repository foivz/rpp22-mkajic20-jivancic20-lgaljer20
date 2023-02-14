using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartBar
{
    public partial class FrmGrafickiPrikazInventara : Form
    {

        //private ProductRepository repo = new ProductRepository(); //private ProductService productServices = new ProductServices()
        private ProductService productServices = new ProductService();
        public FrmGrafickiPrikazInventara()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmGrafickiPrikazInventara_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = System.Windows.Forms.Application.StartupPath + "\\Chm files/Graf.chm";

            var products = productServices.GetProducts();

            List<Tuple<string, int, string>> data = new List<Tuple<string, int, string>>();

            foreach (var product in products)
            {
                data.Add(new Tuple<string, int, string>(product.Name, (int)product.Amount, product.MeasurementUnit));
            }

            MakeChart(data);

        }

        private void MakeChart(List<Tuple<string, int, string>> data)
        {
            chartProducts.Series[0].Points.DataBindXY(data, "Item1", data, "Item2");
            chartProducts.Series[0].XValueMember = "ProductName";
            chartProducts.Series[0].YValueMembers = "ProductAmount";
            chartProducts.Series[0].Label = "#VALX";

            for (int i = 0; i < chartProducts.Series[0].Points.Count; i++)
            {
                DataPoint point = chartProducts.Series[0].Points[i];
                point.ToolTip = string.Format("Količina: {0}", point.YValues[0] + " " + data[i].Item3);
            }

            chartProducts.Series[0].ChartType = SeriesChartType.Pie;
            chartProducts.DataBind();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            {
                var loginService = new LoginService();
                int role = loginService.CheckUserRole();

                if (role == 1)
                {
                    var frmUser = new FrmUser();
                    Hide();
                    frmUser.ShowDialog();
                    Close();
                }
                else
                {
                    var frmAdmin = new FrmAdmin();
                    Hide();
                    frmAdmin.ShowDialog();
                    Close();
                }
            }
        }
    }
}
