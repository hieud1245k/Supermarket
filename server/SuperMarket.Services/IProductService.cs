using System.Collections.Generic;
using SuperMarket.Core.Models;

namespace SuperMarket.Services
{
    public interface IProductService
    {
         List<Product> getAll();

         Product save(Product product);

         void update(Product product);

         void delete(int id);

         Product getById(int id);
    }
}