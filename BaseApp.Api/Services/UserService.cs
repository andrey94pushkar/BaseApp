using BaseApp.Api.DtoBuilders;
using BaseApp.Api.Models.User;
using BaseApp.DataAccess.Models;
using BaseApp.DataAccess.Repositories;
using System;
using System.Linq;

namespace BaseApp.Api.Services
{
    public interface IUserService
    {
        UserDto GetUser(Guid id);
        UserListResponse GetUsers(string term);
        int Add(UserDto dto);
        int Update(UserDto dto);
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
            return UserDtoBuilder.ToDto(_userRepository.GetById(id));
        }

        public UserListResponse GetUsers(string term)
        {
            var response = new UserListResponse();
            var users = _userRepository.GetUsers(term);
            response.Users = users.Select(x => UserDtoBuilder.ToDto(x));
            return response;
        }

        public int Add(UserDto dto)
        {
            return _userRepository.Add(UserDtoBuilder.ToEntity(dto));
        }

        public int Update(UserDto dto)
        {
            var user = _userRepository.GetById(dto.Id.Value);
            user.Avatar = dto.Avatar;
            user.Birthday = dto.Birthday;
            user.Country = dto.Country;
            user.FullName = dto.FullName;
            user.Logo = dto.Logo;
            user.Status = dto.Status;
            return _userRepository.Update(user);
        }
    }
}