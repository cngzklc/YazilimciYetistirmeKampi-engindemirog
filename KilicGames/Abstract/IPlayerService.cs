using KilicGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Abstract
{
    public interface IPlayerService
    {
        void Add(Player person);
        void Update(Player person);
        void Delete(Player person);

    }
}
