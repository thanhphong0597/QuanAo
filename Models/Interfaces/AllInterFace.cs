using Doan.Models;

namespace Doan.Interfaces
{
    public interface ICategory 
    {
        public Task<IEnumerable<CategoryModel>> GetCategories();
        public Task<CategoryModel> GetCategory(int id);
        public Task<int> AddCategory(CategoryModel model);
        public Task UpdateCategory(int id, CategoryModel model);
        public Task DeleteCategory(int id);

    }
    public interface IProduct
    {
        public Task<IEnumerable<ProductModel>> GetProducts();
        public Task<IEnumerable<ProductModel>> GetProduct(int id);
        public Task<int> AddProduct(int id);
        public Task UpdateProduct(int id, ProductModel model);
        public Task DeleteProduct(int id);

    }
}
