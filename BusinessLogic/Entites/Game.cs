using BusinessLogic.Interfaice;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entites
{
    public class Game : IBaseEntity
    {
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Name { get; set; }

        public int GanrId { get; set; }
        public Ganr? Ganr { get; set; }

        [Range(0, 100_000)]
        public decimal Price { get; set; }

        [Range(0, 100_000)]
        public int Memory { get; set; }

        [StringLength(1000, MinimumLength = 10)]
        public string? Description { get; set; }

        [Url]
        public string Logotip { get; set; }
    }
}
