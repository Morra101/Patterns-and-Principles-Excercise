using OrgOffering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Product GetProductById(Guid? id);
        void AddProduct(Product entity);
        void RemoveProduct(Product product);
    }
}
