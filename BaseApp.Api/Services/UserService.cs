using BaseApp.Api.DtoBuilders;
using BaseApp.Api.Models.User;
using BaseApp.DataAccess.Repositories;
using System;
using System.Linq;

namespace BaseApp.Api.Services
{
    public interface IUserService
    {
        UserDto GetUser(Guid id);
        UserListResponse GetUsers(string term);
    }

    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto GetUser(Guid id) 
        {
            return UserDtoBuilder.ToDto(_userRepository.GetUser(id));
        }

        public UserListResponse GetUsers(string term)
        {
            var response = new UserListResponse();
            var users = _userRepository.GetUsers(term);
            response.Users = users.Select(x => UserDtoBuilder.ToDto(x));
            return response;
        }
    }
}