using KilicGames.Player.Entities;

namespace KilicGames.Player.Abstract
{
    public interface IPlayerService
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
