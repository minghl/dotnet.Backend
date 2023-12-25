using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Youshow.Ace.Domain.Models;
using Youshow.Ace.Domain.Repository;

namespace BlogSystem.Domain.AccountInfo
{
    public class User : BaseModel<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Sex { get; set; } = "保密";
        public DateTime Birthday { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public string? Email { get; set; }
        public string? QQ { get; set; }

        public DateTime RegistTime { get; set; }


        // 仓储是可以在数据库里面增删改查的
        /// <summary>
        /// 验证用户登录
        /// </summary>
        /// <param name="userRepo"></param>
        /// <returns></returns>
        public static async Task<User> CheckLogin(string userName, string password, IRepository<User> userRepo)
        {
            var user = await userRepo.GetAsync(u => u.Username == userName && u.Password == password);
            return user;
        }

        public void ValidateRegist()
        {

            Regex regexQQ = new Regex(@"^(?:0|(?:-?[1-9]\d*))$");
            if (!regexQQ.IsMatch(this.QQ))
            {
                throw new Exception("QQ格式不正确");
            }

            Regex regexEmail = new Regex("^(([^<>()[\\]\\.,;:\\s@\"]+(\\.[^<>()[\\]\\.,;:\\s@\"]+)*)|(\".+\"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$");
            if (!regexEmail.IsMatch(this.Email))
            {
                throw new Exception("QQ格式不正确");
            }
            if (this.Birthday == null)
            {
                var defaultBirthDay = "1970-01-01";
                this.Birthday = DateTime.Parse(defaultBirthDay);
            }
            this.RegistTime = DateTime.Now;
        }
    }
}