using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Models.CategoryModels;
using CardShop.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CardShop.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.GetCategories());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _categoryService.GetCategoryById(id));
        }

        [HttpGet]
        public async Task<IActionResult> Post()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(CategoryCreate category)
        {
            if (!ModelState.IsValid) return BadRequest(category);
            if (await _categoryService.CreateCategory(category))
                return RedirectToAction(nameof(Index));
            else
                return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetCategoryById(id);
            var categoryUpdate = new CategoryUpdate
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
            return View(categoryUpdate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CategoryUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _categoryService.UpdateCategory(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            var isSuccessful = await _categoryService.DeleteCategory(id.Value);
            if (isSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();
        }
    }
}