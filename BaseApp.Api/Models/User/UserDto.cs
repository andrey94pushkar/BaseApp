﻿using System;

namespace BaseApp.Api.Models.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string Avatar { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
    }
}
