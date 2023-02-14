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
            helpProvider1.HelpNamespace = System.Windows.Forms.Application.StartupPath + "\\Chm files/Zapisnik.chm";
            inventoryRecordBindingSource.DataSource= servisiRecord.GetRecordById(selectedInventoryId);
            inventoryRecordItemBindingSource.DataSource = servisiItem.GetRecordById(selectedInventoryId);
            productBindingSource.DataSource = servisiItem.GetProductsFromId(selectedInventoryId);
      
            this.rvZapisnik.RefreshReport();
        }

  
    }
}
