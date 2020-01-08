using Microsoft.AspNetCore.Mvc;
using System;
using BaseApp.Api.Services;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using BaseApp.Api.Models.User;
using BaseApp.Api.Models.Errors;

namespace BaseApp.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IStringLocalizer<UserController> _localizer;
        private readonly IUserService _userService;

        public UserController(IUserService userService, IStringLocalizer<UserController> localizer, ILogger<UserController> logger)
        {
            _logger = logger;
            _localizer = localizer;
            _userService = userService;
        }

        /// <summary>
        /// Returns users for autocomplete, fullnames filtered by term
        /// </summary>
        /// <returns></returns>
        /// <response code="200">list of users</response> 
        [HttpGet]
        [Route("autocomplete")]
        [ProducesResponseType(typeof(UserListResponse), 200)]
        public IActionResult Autocomplete(string term)
        {
            return Ok(_userService.GetUsers(term));
        }

        /// <summary>
        /// Returns user by Id
        /// </summary>
        /// <returns></returns>
        /// <response code="200">User</response> 
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(UserDto), 200)]
        [ProducesResponseType(typeof(NotFoundErrorDto), 404)]
        public IActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out Guid validation))
                throw new ValidationException(_localizer["WrongRequest"]);

            UserDto user = _userService.GetUser(Guid.Parse(id));

            if (user == null)
                throw new NotFoundException(_localizer["NotFound"]);

            return Ok(user);
        }


    }
}
