using System;
using KilicGames.Player.Entities;

namespace KilicGames.Player.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Person player)
        {
            Console.WriteLine("Add to db : {0}", player.FirstName);
        }

        public virtual void Delete(Person player)
        {
            Console.WriteLine("Delete to db : {0}", player.FirstName);
        }

        public virtual void Update(Person player)
        {
            Console.WriteLine("Delete to db : {0}", player.FirstName);
        }
    }
}
