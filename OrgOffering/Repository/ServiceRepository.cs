using OrgOffering.Data;
using OrgOffering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(ProductsContext context) : base(context)
        {
        }

        public Service GetMostRecentService()
        {
            return _context.Service.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
        public Service GetServiceById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.ServiceId == id);
        }
        public void AddService(Service entity)
        {
            Add(entity);
        }

        public void RemoveService(Service entity)
        {
            Remove(entity);
        }
    }

}
