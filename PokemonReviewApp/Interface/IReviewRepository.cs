using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface IReviewRepository
    {
        Review GetReview(int reviewId);
        ICollection<Review> GetAllReviews();
        ICollection<Review> GetReviewsByPokemon (int pokemonId);
        bool exsistReview (int reviewId);

    }
}
