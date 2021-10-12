using HbHomework.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbHomework.Repository.Interfaces
{
    public interface IProductRepository: IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductListAsync();
        Task<IEnumerable<Product>> GetProductByNameAsync(string productName);
        Task<Product> GetProductById(int productId);
        Task<IEnumerable<Product>> GetProductByCategoryAsync(string category);
    }
}
