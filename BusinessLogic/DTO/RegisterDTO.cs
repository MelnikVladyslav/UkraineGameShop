using BusinessLogic.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
    public class RegisterDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public TypesUsers TypeUsers { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
