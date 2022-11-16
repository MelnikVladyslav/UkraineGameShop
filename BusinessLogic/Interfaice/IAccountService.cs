using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaice
{
    public interface IAccountService
    {
        Task Register(RegisterDTO data);
        Task Login(string username, string password);
        Task Logout();
    }
}
