using System.Collections.Generic;
using SuperMarket.Core.Models;

namespace SuperMarket.Services
{
    public interface ICategoryService
    {
        List<Category> getAll();

        Category Save(Category category);

        void delete(int id);

        Category Update(Category category);
    }
}