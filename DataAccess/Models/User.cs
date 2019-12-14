using System;

namespace DataAccess.Models
{
    public class User:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string Avatar { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
    }
}
