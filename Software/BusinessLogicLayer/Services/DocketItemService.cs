﻿using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class DocketItemService
    {
        private DocketItemRepository repo = new DocketItemRepository();
        public List<DocketItem> GetDocketsById(int id)
        {
            return repo.GetDocketsById(id);
        }

        public void AddDocketItem(DocketItem docketItem)
        {
            repo.AddDocketItem(docketItem); 
        }
    }
}