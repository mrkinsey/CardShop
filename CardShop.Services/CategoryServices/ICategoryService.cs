using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CategoryModels;

namespace CardShop.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<bool> CreateCategory(CategoryCreate model);
        Task<bool> UpdateCategory(CategoryUpdate model);
        Task<List<CategoryListItem>> GetCategories();
        Task<CategoryDetails> GetCategoryById(int categoryId);
        Task<bool> DeleteCategory(int categoryId);
    }
}