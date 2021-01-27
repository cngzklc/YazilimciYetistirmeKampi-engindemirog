using KilicGames.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Entities
{
    public class Player:IPerson
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirt { get; set; }
    }
}
