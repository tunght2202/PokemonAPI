using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface iPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(String name);
        decimal GetPokemonRating(int id);
        bool PokemonExists(int id);

    }
}
