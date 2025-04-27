using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommerceApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        // Metodos de categorias necesario para poder tener nuestro catalogo y cumplir con las busquedas
        //Solo create para pruebas

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.ParentCategories = new SelectList(categories, "CategoryId", "Name");

            return View();
        }


        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                // Si ParentCategoryId es 0, lo asignamos como null , siendo la categoria padre
                if (category.ParentCategoryId == 0)
                {
                    category.ParentCategoryId = null;
                }

                await _categoryService.CreateAsync(category);
                return RedirectToAction(nameof(Index));
            }

            // Si el modelo no es válido, recargamos las categorías padre para el dropdown
            var categories = await _categoryService.GetAllAsync();
            ViewBag.ParentCategories = new SelectList(categories, "CategoryId", "Name");

            return View(category);
        }

    }
}