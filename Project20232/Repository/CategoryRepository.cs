using Project20232.Data;
using Project202322.Shared.Domain;
using Project20232.Server.IRepository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

namespace Project20232.Server.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            return category;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                return false;

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<Category> GetCategoriesByType(string type)
        {
            return _context.Categories.Where(c => c.Type == type).ToList();
        }

        public IEnumerable<Category> SearchCategoriesByName(string name)
        {
            return _context.Categories.Where(c => c.Name.Contains(name)).ToList();
        }

        public IEnumerable<Category> GetCategoriesByTag(string tag)
        {
            return _context.Categories.Where(c => c.Tags.Contains(tag)).ToList();
        }
    }
}