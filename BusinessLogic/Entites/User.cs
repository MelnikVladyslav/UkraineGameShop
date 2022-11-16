using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entites
{
    public enum TypesUsers : int
    {
        Admin = 1,
        Programmer,
        User
    }

    public class User : IdentityUser
    {
        public TypesUsers TypeUsers { get; set; }
        public ICollection<Game>? Games { get; set; }
    }
}
