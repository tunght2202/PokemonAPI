using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetAllOwnersByPokemon(int pokemonId);
        ICollection<Pokemon> GetAllPokemonbyOwner (int ownerId);
        bool OwnrExistrs (int ownerId);
    }

}
