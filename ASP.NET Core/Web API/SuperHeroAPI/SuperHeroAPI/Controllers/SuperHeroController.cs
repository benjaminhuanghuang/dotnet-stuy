using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        
        public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
        {
            var superHeros = new List<SuperHero> { 
                new SuperHero { Id = 1, Name="a", FirstName= "a", LastName="a", Place= "New York City"}
            };


            return Ok(superHeros);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<SuperHero>> GetSingleHeros(int id)
        {
            var superHeros = new List<SuperHero> {
                new SuperHero { Id = 1, Name="a", FirstName= "a", LastName="a", Place= "New York City"}
            };


            return Ok(superHeros);
        }
    }
}
