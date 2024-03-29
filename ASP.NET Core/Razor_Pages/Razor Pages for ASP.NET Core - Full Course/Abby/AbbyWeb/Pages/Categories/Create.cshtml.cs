﻿using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
            
        public CreateModel(ApplicationDbContext db)
        {
            this._db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(Category category)
        {
            if(category.Name == category.DisplayOrder.ToString()){
                ModelState.AddModelError("DisplayOrder", "DisplayOrder cannot be the same as Name");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _db.Category.AddAsync(category);
            await _db.SaveChangesAsync();
            TempData["success"] =   "Category has been created successfully";
            return RedirectToPage("Index");
        }
    }
}
