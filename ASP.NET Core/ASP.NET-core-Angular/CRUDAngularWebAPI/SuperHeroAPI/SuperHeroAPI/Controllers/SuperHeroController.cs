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

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = await this._superHeroService.AddHero(hero);
            return Ok(result);
        }


        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {
            var result = await this._superHeroService.UpdateHero(request.Id, request);
            if (result == null)
            {
                return NotFound("Hero not found.");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = await this._superHeroService.DeleteHero(id);
            if (result == null)
            {
                return NotFound("Hero not found.");
            }

            return Ok(result);
        }
    }
}
