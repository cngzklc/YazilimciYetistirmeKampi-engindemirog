using KilicGames.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Entities
{
    public class Player
    {
        public int Id { get; internal set; }
        public string NationalityId { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime DateOfBirt { get; internal set; }
    }
}
