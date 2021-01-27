using System;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNme { get; set; }
        public DateTime DateOfBirt { get; set; } // Doğum tarihi
        public string NationalityId { get; set; } //TC Kimlik No
    }

}
