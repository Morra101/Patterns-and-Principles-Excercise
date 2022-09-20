using OrgOffering.Data;
using OrgOffering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductsContext context):base (context)
        {

        }

        public Product GetProductById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.ProductId == id);
        }
        public void AddProduct(Product entity)
        {
            Add(entity);
        }

        public void RemoveProduct(Product entity)
        {
            Remove(entity);
        }

    }
}
