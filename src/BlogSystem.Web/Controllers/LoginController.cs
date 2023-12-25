using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.UserApp;
using BlogSystem.Ability.Docking.UserApp.Dto;
using BlogSystem.Ability.UserApp;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class LoginController : ControllerBase
    {
        public IUserServicer UserServicer { get; set; }
        [HttpGet]
        public async Task<LoginSuccessDto> CheckLogin(string userName, string password)
        {
            return await UserServicer.CheckLogin(userName, password);
        }
    }
}