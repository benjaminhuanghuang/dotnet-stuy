using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    //[Authorize(Roles = "Admin,Admin1,Admin2")]
    //[Authorize(Roles = "Manager")]
    [Authorize(Policy = "GraduatedOnly")]
    public class AddMovieModel : PageModel
    {
        [BindProperty]   // two way binding
        public string Title { get; set; }

        [BindProperty]
        public int Rate { get; set; }

        [BindProperty]
        public string Description { get; set; }

        private ApplicationDbContext _context;
        public AddMovieModel(ApplicationDbContext context)
        {
            _context = context;
        }


        public void OnGet()
        {
            // Title = "Welcome";
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var movie = new Movie()
            {
                Title = Title,
                Rate = Rate,
                Description = Description
            };
            _context.Movies.Add(movie);
            _context.SaveChanges();

            //return Page();
            return Redirect("Movies");
        }
    }
}