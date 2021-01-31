using KilicGames.Games.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Games.Entities
{
    public class GameCategory:IGameCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
