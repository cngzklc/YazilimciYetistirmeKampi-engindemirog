using KilicGames.Abstract;
using KilicGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Concrete
{
    public class PlayerManager:BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager( IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Add(player);
            }
            else
            {
                Console.WriteLine("Geçerli kişi değil");
                //throw new Exception("Not a valid person");//Gerçerli bir kişi değil
            }
        }
        public override void Delete(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Delete(player);
            }
            else
            {
                Console.WriteLine("Geçerli kişi değil");
                //throw new Exception("Not a valid person");//Gerçerli bir kişi değil
            }
        }
        public override void Update(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Update(player);
            }
            else
            {
                Console.WriteLine("Geçerli kişi değil");
                //throw new Exception("Not a valid person");//Gerçerli bir kişi değil
            }
        }
    }
}
