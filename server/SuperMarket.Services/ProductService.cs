using System.Collections.Generic;
using System.Linq;
using SuperMarket.Core;
using SuperMarket.Core.Models;

namespace SuperMarket.Services
{
    public class ProductService : IProductService
    {

        private DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public void delete(int id)
        {
            var product = getById(id);
            if(product == null)
                return;
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> getAll()
        {
            return _context.Products.ToList();
        }

        public Product getById(int id)
        {
            return _context.Products.FirstOrDefault(s => s.Id == id);
        }

        public Product save(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void update(Product product)
        {
            var oldProduct = getById(product.Id);
            if(oldProduct == null)
                return;
            oldProduct.Name = product.Name;
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}