using System.Collections.Generic;
using System.Linq;
using SuperMarket.Core;
using SuperMarket.Core.Models;

namespace SuperMarket.Services
{
    public class CategoryService : ICategoryService
    {

        private DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public void delete(int id)
        {
            // Category category = _context.Categories.FirstOrDefault
            // _context.Categories.Remove(id);
        }

        public List<Category> getAll()
        {
            return _context.Categories.ToList();
        }

        public Category Save(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category Update(Category category)
        {
            if(category.Id != null) 
                return Save(category);
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}