using KilicGames.Games.Entities;

namespace KilicGames.Games.Abstract
{
    public interface IGameCategoryService
    {
        void Add(GameCategory gameCategory);
        void Delete(GameCategory gameCategory);
        void Update(GameCategory gameCategory);
    }
}
