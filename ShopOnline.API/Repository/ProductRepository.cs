﻿using ShopOnline.API.Entities;
using ShopOnline.API.Repository.Contracts;

namespace ShopOnline.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<ProductCategory>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}