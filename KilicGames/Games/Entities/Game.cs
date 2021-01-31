using KilicGames.Games.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Games.Entities
{
    public class Game : IProduct
    {
        private double PriceWithhKDV;
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get { return PriceWithhKDV; } set { PriceWithhKDV = value * 1.18; } }
        public int GameCategoryId { get; set; }
    }
}
