using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DocketRepository
    {
        public List<Docket> GetAllDockets()
        {
            using (var context = new DataBaseModel())
            {
                return context.Dockets.ToList();
            }
        }
    }
}
