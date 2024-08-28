using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonsByCateogory(int cateogoryId);
        bool CateogoryExists(int id);

    }
}
