using PokemonReviewApp.Data;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Models;
using System.Reflection.Metadata.Ecma335;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : iPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id) => _context.Pokemons.FirstOrDefault(p => p.Id == id);

        public Pokemon GetPokemon(string name) => _context.Pokemons.FirstOrDefault(p => p.Name == name);

        public decimal GetPokemonRating(int id)
        {
            var reviews = _context.Reviews.Where(r => r.Pokemon.Id == id);
            if (reviews.Count() <= 0)
            {
                return 0;
            }

            return ((decimal)reviews.Sum(r => r.Rating) / reviews.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int id) => _context.Pokemons.Any(p => p.Id == id);
    } 
}
