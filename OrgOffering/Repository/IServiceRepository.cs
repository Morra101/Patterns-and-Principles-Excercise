using OrgOffering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
        Service GetServiceById(Guid? id);
        void AddService(Service entity);
        void RemoveService(Service service);
    }

}
