using Doan.Interfaces;
using Doan.Service;
using Microsoft.EntityFrameworkCore;

namespace Doan.Models.Reposities
{
    public class ProductRepo : IProduct
    {
        private readonly Context db;

        public ProductRepo(Context db)
        {
            this.db = db;
        }

        public Task<int> AddProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductModel>> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        //httpget
        //public async Task<IEnumerable<ProductModel>> GetProducts()
        //{
        //    //return await (from p in db.Products
        //    //              select new ProductModel
        //    //              {
        //    //                  ID = p.ColorID
        //    //                      Name = p.
        //    //                  Count = p.Count,
        //    //                  Description = p.Description,
        //    //                  Ima = p.Ima,
        //    //                  Price = p.Price,
        //    //                  Rate = p.Rate,
        //    //                  Title = p.Title
        //    //              }).ToListAsync();
        //}

        public Task UpdateProduct(int id, ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
