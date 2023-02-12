using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class DocketService
    {
        private DocketRepository repo = new DocketRepository();
        public List<Docket> GetAllDockets()
        {

            return repo.GetAllDockets().ToList();
        }
        public void AddDocket(Docket docket)
        {
            repo.Add(docket);
        }


        public bool RemoveDocket(Docket docket)
        {
            bool uspjesno = false;
        
            bool mozeObrisati = ProvjeraBrisanje(docket);
            if(mozeObrisati == true)
            {          
               repo.Remove(docket);
               uspjesno = true;     
            }

            return uspjesno;
        }

        private bool ProvjeraBrisanje(Docket docket)
        {
            var count = repo.GetCount(docket);
         
                if (count > 0)
                {
                    return false;
                }
                return true;           
        }
  
    }
}
