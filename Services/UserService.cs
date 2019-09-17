using DataAccess.Repositories;
using Domain;
using System;
using System.Collections.Generic;

namespace Services
{
    public class UserService
    {
        private IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(User user)
        {
            _unitOfWork.GetRepository<User>().Add(user);
            _unitOfWork.SaveContext();
        }

        public User GetImgById(int id)
        {
            User user = new User();
            user = _unitOfWork.GetRepository<User>().Get(id);
            return user;
        }

        public List<User> GetAllImg()
        {
            List<User> users = new List<User>();
            users = _unitOfWork.GetRepository<User>().Get();
            return users;
        }

        public List<User> GetImgsByCategoryId(int id)
        {
            List<User> user = new List<User>();
            user = _unitOfWork.GetRepository<User>().Get().FindAll(item => item.Id == id);
            return user;
        }
    }
}
