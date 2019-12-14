using System.Collections.Generic;
using DataAccess;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Models;
using System;

namespace BaseApp.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private BaseAppDbContext _context;
        private UserRepository _userRepository;
        
       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userRepository.GetUsers());
        }


        [HttpGet("{id}")]
        public User Get(Guid id)
        {
           User userObject = _userRepository.GetUser(id);
            if (userObject == null)
                return null;
            return userObject;

        }
    }
}
