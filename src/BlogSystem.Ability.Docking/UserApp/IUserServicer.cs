using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.UserApp.Dto;
using Youshow.Ace.Ability.Services;

namespace BlogSystem.Ability.Docking.UserApp
{
    public interface IUserServicer : IAbilityServicer
    {
        Task<LoginSuccessDto> CheckLogin(string userName, string password);
        Task<bool> RegistUser(UserCreateDto createDto);
    }
}