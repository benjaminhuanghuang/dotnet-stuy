using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services
{
    public class SuperHeroService: ISuperHeroService
    {
        private readonly DataContext _context;
        public SuperHeroService(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<SuperHero>> GetAllHeroes()
        {
            var heros = await this._context.SuperHeros.ToListAsync();
            return await this._context.SuperHeros.ToListAsync();
        }

        public async Task<SuperHero?> GetSingleHero(int id)
        {
            var hero = await this._context.SuperHeros.FindAsync(id);
            return hero;
        }

        public async Task<List<SuperHero>?> UpdateHero(int id, SuperHero request)
        {
            var hero = await this._context.SuperHeros.FindAsync(id);
            if (hero == null)
            {
                return null;
            }

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            await this._context.SaveChangesAsync();

            return await this._context.SuperHeros.ToListAsync();
        }

        public async Task<List<SuperHero>> AddHero(SuperHero hero)
        {
            this._context.SuperHeros.Add(hero);
            await this._context.SaveChangesAsync();

            return await this._context.SuperHeros.ToListAsync();
        }

        public async Task<List<SuperHero>?> DeleteHero(int id)
        {
            var hero = await this._context.SuperHeros.FindAsync(id);
            if (hero == null)
            {
                return null;
            }

            _context.SuperHeros.Remove(hero);
            await this._context.SaveChangesAsync();

            return await this._context.SuperHeros.ToListAsync();
        }
    }
}
