using SuperHeroAPI.Data;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroServiceInMemory
    {
        private List<SuperHero> superHeros = new List<SuperHero> {
            new SuperHero { Id = 1, Name="a", FirstName= "a", LastName="a", Place= "New York City"}
        };

        public List<SuperHero> AddSuperHero(SuperHero hero)
        {
            this.superHeros.Add(hero);
            return superHeros;
        }

        public List<SuperHero> DeleteSuperHero(int id)
        {
            var hero = superHeros.Find(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }
            superHeros.Remove(hero);

            return superHeros;
        }

        public List<SuperHero> GetAllHeros()
        {
            return superHeros;
        }

        public SuperHero? GetSingleSuperHero(int id)
        {
            var hero = this.superHeros.FirstOrDefault(x => x.Id == id);
            return hero;
        }

        public List<SuperHero> UpdateSuperHero(int id, SuperHero hero)
        {
            var _hero = this.superHeros.Find(x => x.Id == id);
            if (_hero == null)
            {
                return null;
            }
            _hero.Name = hero.Name;
            _hero.FirstName = hero.FirstName;
            _hero.LastName = hero.LastName;
            _hero.Place = hero.Place;

            return superHeros;
        }
    }
}
