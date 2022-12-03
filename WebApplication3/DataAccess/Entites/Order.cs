using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public string ClientId { get; set; }
        public User? Client { get; set; }
        public IEnumerable<Game> Products { get; set; }
    }
}
