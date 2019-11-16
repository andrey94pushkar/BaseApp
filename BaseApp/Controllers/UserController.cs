using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaseApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns>list of users</returns>
        [Route("users")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [HttpGet]
        public IActionResult GetUsers()
        {
            var result = _userRepository.GetUsers();
            return Ok(result);
        }
    }
}