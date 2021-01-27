using KilicGames.Abstract;
using KilicGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Concrete
{
    public class PlayerManager:IPlayerService
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager( IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(IPerson person)
        {
            throw new NotImplementedException();
        }

        public void Delete(IPerson person)
        {
            throw new NotImplementedException();
        }

        public void Update(IPerson person)
        {
            throw new NotImplementedException();
        }
    }
}
