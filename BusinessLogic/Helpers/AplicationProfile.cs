using BusinessLogic.DTO;
using BusinessLogic.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public class AplicationProfile : AutoMapper.Profile
    {
        public AplicationProfile()
        {
            CreateMap<Game, GameDTO>()
                .ForMember(dest => dest.Ganr,
                           opt => opt.MapFrom(src => src.Ganr.Name));
            CreateMap<GameDTO, Game>();
        }
    }
}
