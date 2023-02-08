using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBar.ViewModels
{
    public class UpravljanjeInvantaromVM
    {
        [System.ComponentModel.DisplayName("ID")]
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Cijena")]
        public double? Price{ get; set; }
        [System.ComponentModel.DisplayName("Naziv")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("Količina")]
        public int? Amount { get; set; }
        [System.ComponentModel.DisplayName("Minimalna količina")]
        public int? Minimum { get; set; }
        [System.ComponentModel.DisplayName("Optimalna količina")]
        public int? Optimal { get; set; }
        [System.ComponentModel.DisplayName("Mjerna jedinica")]
        public string MeasurementUnit { get; set; }        
    }
}
