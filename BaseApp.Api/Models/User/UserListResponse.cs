using System.Collections.Generic;

namespace BaseApp.Api.Models.User
{
    public class UserListResponse
    {
        public UserListResponse()
        {
            Users = new List<UserDto>();
        }

        public IEnumerable<UserDto> Users { get; set; }
    }
}
