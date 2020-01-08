using System;

namespace BaseApp.DataAccess.Models
{
    public class User:Entity
    {
        public string FullName { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string Avatar { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
    }
}
