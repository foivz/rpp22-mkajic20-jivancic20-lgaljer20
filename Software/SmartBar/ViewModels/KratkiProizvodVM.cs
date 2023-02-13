using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBar.ViewModels
{
    public class KratkiProizvodVM
    {
        [System.ComponentModel.DisplayName("Naziv proizvoda")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("Količina na skladištu")]
        public int? Amount { get; set; }
        [System.ComponentModel.DisplayName("Količina narudžbe")]
        public int? OrderAmount { get; set; }
        
    }
}
