using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HbHomework.Models;
namespace HbHomework.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductList();
        Task<Product> GetProductById(int productId);
        Task<Product> GetProductByCategory(string category);
        Task<IEnumerable<Product>> GetProductByName(string productName);
        Task<Product> Create(Product productModel);
        Task Update(Product product);
        Task Delete(Product product);
    }
}
