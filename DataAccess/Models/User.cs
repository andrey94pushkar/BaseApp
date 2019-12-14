using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Countru { get; set; }
        public DateTime Birthday { get; set; }
        public string Avatar { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
       

    }
}
