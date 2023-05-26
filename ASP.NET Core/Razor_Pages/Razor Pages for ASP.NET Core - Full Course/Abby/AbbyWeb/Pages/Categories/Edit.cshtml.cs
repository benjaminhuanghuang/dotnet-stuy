using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace AbbyWeb.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            this._db = db;
        }

        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
            // Category =_db.Category.FirstOrDefault(u => u.Id == id);
            // Category =_db.Category.SingleOrDefault(u => u.Id == id);
            // Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
        }

        public async Task<IActionResult> OnPostAsync(Category category)
        {
            if(category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("DisplayOrder", "DisplayOrder cannot be the same as Name");
            }
            if (ModelState.IsValid)
            {
                _db.Category.Update(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category has been updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }   
    }
}
