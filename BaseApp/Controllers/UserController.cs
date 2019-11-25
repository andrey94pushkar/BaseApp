using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Repositories;
using Domain;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;

namespace BaseApp.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private BaseAppDbContext _context;
        private IUnitOfWork _unitOfWork = new UnitOfWork();
       
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            //var users = new User[]
            //     {
            //    new User
            //    {

            //        FirstName = "Dart",
            //        LastName = "Vaider",
            //        Countru = "Distant Galaxy",
            //        Birthday = DateTime.Parse("03.03.0003"),
            //        Avatar = "https://cdn-st1.rtr-vesti.ru/p/xw_1138944.jpg",
            //        Logo = "https://toptos.com.ua/content/images/5/populyarnyy-popsoket-pop-socket-dlya-parnya-dart-veyder-56860954500598_small11.jpg",
            //        Status = "SPACE DIRECTOR"
            //    },
            //    new User
            //    {

            //        FirstName = "Harley",
            //        LastName = "Quean",
            //        Countru = "USA",
            //        Birthday = DateTime.Parse("02.02.0002"),
            //        Avatar = "https://www.soyuz.ru/public/uploads/files/2/7234415/201811211258136d8102972b.jpg",
            //        Logo = "https://24smi.org/public/media/person/2017/11/28/3xrsu8dknklx-kharli-kvinn.jpg",
            //        Status = "PROFESSIONAL CRIMINAL"
            //    },
            //    new User
            //    {

            //        FirstName = "Sherlock",
            //        LastName = "Holmes",
            //        Countru = "England",
            //        Birthday = DateTime.Parse("01.01.0001"),
            //        Avatar = "https://volginblog.files.wordpress.com/2017/02/d0bcd0b8d0bdd0b8d0b0d182d18ed180d0b0.jpg?w=605",
            //        Logo = "https://images.ua.prom.st/1921214880_w640_h640_kniga-dumati-yak.jpg",
            //        Status = "DETECTIVE-FREELANCER"
            //    },
            //};
            //foreach (User s in users)
            //{
            //    _unitOfWork.GetRepository<User>().Add(s);
            //}
            //_unitOfWork.SaveContext();
            return _unitOfWork.GetRepository<User>().Get(); 
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
           User userObject = _unitOfWork.GetRepository<User>().Get(id);
            if (userObject == null)
                return null;
            return userObject;

        }
    }
}
