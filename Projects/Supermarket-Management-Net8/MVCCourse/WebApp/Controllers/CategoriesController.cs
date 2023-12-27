using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();

            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "Edit";

            var category  = CategoriesRepository.GetCategoryById(id ?? 0);

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if(ModelState.IsValid)
            {
                CategoriesRepository.UpdateCategory(category.CategoryId, category);

                return RedirectToAction(nameof(Index));
            }

            return View(category);
          
        }

        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoriesRepository.AddCategory(category);

                return RedirectToAction(nameof(Index));
            }

            return View(category);

        }

        public IActionResult Delete(int? id)
        {
            CategoriesRepository.DeleteCategory(id ?? 0);

            return RedirectToAction(nameof(Index));
        }   
    }
}
