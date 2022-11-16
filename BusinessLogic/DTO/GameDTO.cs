using BusinessLogic.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GanrId { get; set; }
        public Ganr? Ganr { get; set; }
        public decimal Price { get; set; }
        public int Memory { get; set; }
        public string? Description { get; set; }
        public string Logotip { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
