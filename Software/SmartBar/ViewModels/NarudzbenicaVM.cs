using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBar.ViewModels
{
    public class NarudzbenicaVM
    {
        [System.ComponentModel.DisplayName("ID")]
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Dobavljač")]
        public string SupplierName { get; set; }
        [System.ComponentModel.DisplayName("Korisnik")]
        public string UserName { get; set; }
        [System.ComponentModel.DisplayName("Datum narudžbe")]
        public DateTime? OrderDate { get; set; }
    }
}
