using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaice
{
    public interface IOrderService
    {
        IEnumerable<OrderDTO> GetAll();
        OrderDTO? Get(int id);
        void Create(OrderDTO phone);
        void Edit(OrderDTO phone);
        void Delete(int id);
    }
}
