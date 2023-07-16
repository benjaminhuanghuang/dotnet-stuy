using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            this._superHeroService = superHeroService;
        }


        [HttpGet]

        public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
        {
            var result = await this._superHeroService.GetAllHeros();

            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<SuperHero>> GetSingleHeros(int id)
        {
            var result = await this._superHeroService.GetSingleHero(id);
            if (result == null)
            {
                return NotFound("Hero not found");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = await this._superHeroService.AddHero(hero);
            return Ok(result);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var result = await this._superHeroService.UpdateHero(id, request);
            if (result == null)
            {
                return NotFound("Hero not found.");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = this._superHeroService.DeleteHero(id);
            if (result == null)
            {
                return NotFound("Hero not found.");
            }

            return Ok(result);
        }
    }
}
