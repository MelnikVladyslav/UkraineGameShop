using BusinessLogic.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public string ClientId { get; set; }
        public User? Client { get; set; }
        public ICollection<Game>? Products { get; set; }
    }
}
