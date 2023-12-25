using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.UserApp;
using BlogSystem.Ability.Docking.UserApp.Dto;
using BlogSystem.Domain.AccountInfo;
using Youshow.Ace.Ability;
using Youshow.Ace.Domain.Repository;

namespace BlogSystem.Ability.UserApp
{
    public class UserServicer : AbilityServicer, IUserServicer
    {
        // 封装了增删改查的帮助类库
        public IRepository<User> UserRepo { get; set; }
        public async Task<LoginSuccessDto> CheckLogin(string userName, string password)
        {
            var user = await User.CheckLogin(userName, password, UserRepo);
            var res = ModelMapper.Map<User, LoginSuccessDto>(user);
            res.Token = Guid.NewGuid().ToString();
            return res;
        }

        public async Task<bool> RegistUser(UserCreateDto createDto)
        {
            try
            {
                var user = ModelMapper.Map<UserCreateDto, User>(createDto);
                user.ValidateRegist();
                await UserRepo.InsertAsync(user);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}