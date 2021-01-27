using KilicGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player person)
        {
            Console.WriteLine("Add to db : {0}", person.FirstName);
        }

        public virtual void Delete(Player person)
        {
            Console.WriteLine("Delete to db : {0}", person.FirstName);
        }

        public virtual void Update(Player person)
        {
            Console.WriteLine("Delete to db : {0}", person.FirstName);
        }
    }
}
