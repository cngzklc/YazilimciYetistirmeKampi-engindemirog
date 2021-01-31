using KilicGames.Player.Abstract;
using KilicGames.Player.Entities;
using System;

namespace KilicGames.Player.Adapter
{
    public class PlayerCheckService : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return true;
        }
    }
}
