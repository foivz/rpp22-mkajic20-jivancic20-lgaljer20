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
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartBar
{
    public partial class FrmGraphProduct : Form
    {
       
   
        public FrmGraphProduct()
        {
            InitializeComponent();
         
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmGraphProduct_Load(object sender, EventArgs e)
        {

            GraphProductService service = new GraphProductService();
            var products = service.GetAllGraph();

            List<Tuple<string, int>> data = new List<Tuple<string, int>>();

            foreach (var product in products)
            {
                data.Add(new Tuple<string, int>(product.Name, (int)product.Amount));
            }

            MakeChart(data);
         
        }

        private void MakeChart(List<Tuple<string, int>> data)
        {
            chartProducts.Series[0].Points.DataBindXY(data, "Item1", data, "Item2");
            chartProducts.Series[0].XValueMember = "ProductName";
            chartProducts.Series[0].YValueMembers = "ProductAmount";
            chartProducts.Series[0].Label = "#VALX";

            foreach (DataPoint point in chartProducts.Series[0].Points)
            {
                point.ToolTip = string.Format("Količina: {0}",point.YValues[0]);
            }

            chartProducts.Series[0].ChartType = SeriesChartType.Pie;
            chartProducts.DataBind();
        }
    }
}
