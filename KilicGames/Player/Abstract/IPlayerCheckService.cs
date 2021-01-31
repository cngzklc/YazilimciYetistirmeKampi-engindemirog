using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilicGames.Player.Entities;

namespace KilicGames.Player.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Person person);
    }
}
