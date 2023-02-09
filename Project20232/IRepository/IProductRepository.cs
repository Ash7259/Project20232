using System.Collections.Generic;
using System.Threading.Tasks;
using Project202322.Shared.Domain;
using Project2023.Server.IRepository;

namespace Project2023.Server.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Task<Product> GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);

        IEnumerable<Product> GetProductsByCategory(int categoryId);
        IEnumerable<Product> SearchProductsByName(string name);
        IEnumerable<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice);
    }
}