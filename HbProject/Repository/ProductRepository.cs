using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HbHomework.Data;
using HbHomework.Models;
using HbHomework.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HbHomework.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(Context dbContext) : base(dbContext)
        {
        }

        
        public async Task<IEnumerable<Product>> GetProductByNameAsync(string productName)
        {
           
             return await GetAsync(x => x.Name.ToLower().Contains(productName.ToLower()));

            
            //return await _dbContext.Products
            //    .Where(x => x.ProductName.Contains(productName))
            //    .ToListAsync();
        }


        public async Task<IEnumerable<Product>> GetProductByCategoryAsync(string category)
        {
            return await _dbContext.Products
                .Where(x => x.Category == category)
                .ToListAsync();
        }

        public Task<IEnumerable<Product>> GetProductListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _dbContext.Products.FindAsync(productId);

        }
    }
}
