using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DocketItemRepository
    {

        public List<DocketItem> GetDocketsById(int id)
        {
            using (var context = new DataBaseModel())
            {
                var query = from d in context.DocketItems
                            where d.DocketId == id
                            select d;

                return query.ToList();
            }
        }
    }
}
