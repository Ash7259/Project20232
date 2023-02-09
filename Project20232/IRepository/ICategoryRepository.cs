using Project202322.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Project20232.Server.IRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Task<Category> GetCategory(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        Task<bool> DeleteCategory(int id);
        IEnumerable<Category> GetCategoriesByType(string type);
        IEnumerable<Category> SearchCategoriesByName(string name);
        IEnumerable<Category> GetCategoriesByTag(string tag);
    }
}