using KilicGames.Abstract;
using KilicGames.Adapter;
using KilicGames.Concrete;
using KilicGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Id = 1,
                NationalityId = "25684908800",
                FirstName ="Cengiz",
                LastName="Kılıç",
                DateOfBirt=new DateTime(1985,8,7)

            };
            BasePlayerManager basePlayerManager = new PlayerManager(new MernisServiceAdapter());
            basePlayerManager.Add(player1);
            Console.ReadLine();

        }
    }
}
