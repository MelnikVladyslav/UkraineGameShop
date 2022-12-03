using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entites
{
    public enum Ganrs : int
    {
        Strategy = 1,
        Shuter,
        Arcady,
        Survival,
        VisualNovel,
        BattleRoyale
    }
    public class Ganr
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; } = new HashSet<Game>();
    }
}
