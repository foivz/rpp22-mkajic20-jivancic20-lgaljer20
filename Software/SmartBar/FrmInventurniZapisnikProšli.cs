using BusinessLogicLayer.Services;
using DataAccessLayer;
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
    public partial class FrmInventurniZapisnikProšli : Form
    {
        private int selectedInventoryId;

        private InventoryRecordService servisiRecord = new InventoryRecordService();
        private InventoryRecordItemService servisiItem= new InventoryRecordItemService();
        public FrmInventurniZapisnikProšli(int inventoryRecordId)
        {
            InitializeComponent();
            selectedInventoryId = inventoryRecordId;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void FrmInventurniZapisnikProšli_Load(object sender, EventArgs e)
        {
            inventoryRecordBindingSource.DataSource= servisiRecord.GetRecordById(selectedInventoryId);
            inventoryRecordItemBindingSource.DataSource = servisiItem.GetRecordById(selectedInventoryId);
            productBindingSource.DataSource = servisiItem.GetProductsFromId(selectedInventoryId);
            //using (var context = new DataBaseModel())
            //{
            //    var query = from i in context.InventoryRecords
            //                where i.Id == selectedInventoryId
            //                select i;

            //    InventoryRecord record = query.Single();
            //    inventoryRecordBindingSource.DataSource = record;

            //    var queryItem = from i in context.InventoryRecordItems
            //                    where i.InventoryRecordId == selectedInventoryId
            //                    select i;


            //   List<InventoryRecordItem> itemRecord = queryItem.ToList();
            //    inventoryRecordItemBindingSource.DataSource = itemRecord;


            //    var queryProduct = from i in context.InventoryRecordItems
            //                       where i.InventoryRecordId == selectedInventoryId
            //                       select i.Product;
                
            //    List<Product> selectedProducts = queryProduct.ToList();

            //    productBindingSource.DataSource = selectedProducts;


            

           // }
            this.rvZapisnik.RefreshReport();
        }

  
    }
}
