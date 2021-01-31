using KilicGames.Player.Abstract;
using KilicGames.Player.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Player.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Person player)
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
        public override void Delete(Person player)
        {
            base.Delete(player);
        }
        public override void Update(Person player)
        {
            base.Update(player);
        }
    }
}
