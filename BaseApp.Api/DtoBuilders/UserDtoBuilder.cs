using BaseApp.Api.Models.User;
using BaseApp.DataAccess.Models;
using System;

namespace BaseApp.Api.DtoBuilders
{
    public static class UserDtoBuilder
    {
        public static UserDto ToDto(User model)
        {
            if (model == null)
                return null;

            return new UserDto
            {
                Id = model.Id,
                CreatedAt = model.CreatedAt,
                ModifiedAt = model.ModifiedAt,
                FullName = model.FullName,
                Country = model.Country,
                Birthday = model.Birthday,
                Avatar = model.Avatar,
                Logo = model.Logo,
                Status = model.Status
            };
        }

        public static User ToEntity(UserDto model)
        {
            if (model == null)
                return null;

            return new User
            {
                FullName = model.FullName,
                Country = model.Country,
                Birthday = model.Birthday.Value,
                Avatar = model.Avatar,
                Logo = model.Logo,
                Status = model.Status
            };
        }
    }
}
