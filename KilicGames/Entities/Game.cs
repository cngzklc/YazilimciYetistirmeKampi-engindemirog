using KilicGames.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Entities
{
    public class Game
    {
        private double PriceWithhKDV ;
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get { return PriceWithhKDV; } set { PriceWithhKDV = value * 1.18; } }
        public int GameCategoryId { get; set; }
    }
}
