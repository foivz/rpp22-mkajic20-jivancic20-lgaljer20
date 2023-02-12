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
    }
}
