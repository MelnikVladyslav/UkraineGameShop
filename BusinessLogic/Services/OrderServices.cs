using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.Entites;
using BusinessLogic.Exceptions;
using BusinessLogic.Interfaice;
using BusinessLogic.Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class OrderServices : IOrderService
    {
        private readonly IRepository<Order> GameRepo;
        private readonly IMapper mapper;

        public OrderServices(IRepository<Order> GameRepo, IMapper mapper)
        {
            this.GameRepo = GameRepo;
            this.mapper = mapper;
        }

        public void Create(OrderDTO game)
        {
            GameRepo.Insert(mapper.Map<Order>(game));
            GameRepo.Save();
        }

        public void Delete(int id)
        {
            var game = GameRepo.GetByID(id);

            if (game == null)
                throw new HttpException(ErrorMessages.NotFound, HttpStatusCode.NotFound);

            GameRepo.Delete(game);
            GameRepo.Save();
        }

        public void Edit(OrderDTO game)
        {
            GameRepo.Update(mapper.Map<Order>(game));
            GameRepo.Save();
        }

        public OrderDTO? Get(int id)
        {
            var game = GameRepo.GetByID(id);

            if (game == null)
                throw new HttpException(ErrorMessages.NotFound, HttpStatusCode.NotFound);

            return mapper.Map<OrderDTO>(game);
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            var games = GameRepo.Get(includeProperties: $"{nameof(Game.Ganr)}");
            return mapper.Map<IEnumerable<OrderDTO>>(games);
        }
    }
}
