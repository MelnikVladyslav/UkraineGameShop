using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaice
{
    public interface IGameService
    {
        IEnumerable<GameDTO> GetAll();
        GameDTO? Get(int id);
        void Create(GameDTO phone);
        void Edit(GameDTO phone);
        void Delete(int id);
    }
}
