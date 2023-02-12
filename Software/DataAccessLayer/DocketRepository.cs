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
        public void Add(Docket docket)
        {
            using (var context = new DataBaseModel())
            {
               
                context.Dockets.Attach(docket);
                context.Dockets.Add(docket);
                context.SaveChanges();
            }
        }
        public int GetCount(Docket docket)
        {
            using (var context = new DataBaseModel())
            {
                var query = from i in context.DocketItems
                            where i.DocketId == docket.Id
                            select i;
                return query.Count();   
            }
        }
        public void Remove(Docket docket)
        {
            using (var context = new DataBaseModel())
            {
                context.Dockets.Attach(docket);
                context.Dockets.Remove(docket);
                context.SaveChanges();

            }
        }

     
    }
}
