using KilicGames.Player.Adapter;
using KilicGames.Player.Concrete;
using KilicGames.Player.Abstract;
using KilicGames.Player.Entities;
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
            Person player1 = new Person
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
