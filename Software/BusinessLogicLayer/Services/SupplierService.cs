using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class SupplierService
    {
        public List<Supplier> GetSuppliers()
        {
            using (SupplierRepository supplierRepository = new SupplierRepository())
            {
                return supplierRepository.GetSuppliers();
            }
        }
        public Supplier GetSupplierById(int id)
        {
            using (SupplierRepository supplierRepository = new SupplierRepository())
            {
                return supplierRepository.GetSupplierById(id);
            }
        }
    }
}
