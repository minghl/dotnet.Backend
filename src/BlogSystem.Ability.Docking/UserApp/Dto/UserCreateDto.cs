using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSystem.Ability.Docking.UserApp.Dto
{
    public class UserCreateDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public string? Email { get; set; }
        public string? QQ { get; set; }
    }
}