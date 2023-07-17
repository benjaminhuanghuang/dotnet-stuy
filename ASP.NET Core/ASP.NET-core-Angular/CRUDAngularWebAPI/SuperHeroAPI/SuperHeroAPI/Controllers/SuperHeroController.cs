using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
        {
            return new List<SuperHero>
           {
               new SuperHero {Id = 1, Name = "Batman", FirstName = "Bruce", LastName = "Wayddddne", Place = "Gotham City"},
           };
        }

    }
}
