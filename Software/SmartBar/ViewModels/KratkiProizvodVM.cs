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
        [System.ComponentModel.DisplayName("Kolicina na skladistu")]
        public int? Amount { get; set; }
        [System.ComponentModel.DisplayName("Kolicina narudzbe")]
        public int? OrderAmount { get; set; }
        
    }
}
