using KilicGames.Abstract;
using KilicGames.Entities;
using System;

namespace KilicGames.Adapter
{
    class NewMernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player customer)
        {
            return true;
        }
    }
}
