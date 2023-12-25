using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.UserApp;
using BlogSystem.Ability.Docking.UserApp.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class UserController : ControllerBase
    {
        public IUserServicer UserServicer { get; set; }
        [HttpPost]
        public async Task<bool> RegistUser(UserCreateDto createDto)
        {
            return await UserServicer.RegistUser(createDto);
        }
    }
}