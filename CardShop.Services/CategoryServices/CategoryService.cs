using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CardShop.Data.Context;
using CardShop.Data.Entities;
using CardShop.Models.CategoryModels;
using Microsoft.EntityFrameworkCore;

namespace CardShop.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CategoryService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCategory(CategoryCreate model)
        {
            var category = _mapper.Map<Category>(model);
            await _context.Categories.AddAsync(category);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCategory(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);

            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<List<CategoryListItem>> GetCategories()
        {
            var conversion = await _context.Categories.ToListAsync();
            return _mapper.Map<List<CategoryListItem>>(conversion);
        }

        public async Task<CategoryDetails> GetCategoryById(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            return (category is null) ? null : new CategoryDetails
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
        }

        public async Task<bool> UpdateCategory(CategoryUpdate model)
        {
            var category = await _context.Categories.FindAsync(model.Id);
            if (category is null) return false;

            category.CategoryName = model.CategoryName;

            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
    }
}