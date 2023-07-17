using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            this._superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var result = await this._superHeroService.GetAllHeroes();

            return Ok(result);
        }

    }
}
