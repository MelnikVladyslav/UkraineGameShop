﻿using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.Entites;
using BusinessLogic.Exceptions;
using BusinessLogic.Interfaice;
using BusinessLogic.Resourses;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository<Game> GameRepo;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public GameService(IRepository<Game> GameRepo, IMapper mapper,
                              UserManager<User> userManager,
                              SignInManager<User> signInManager)
        {
            this.GameRepo = GameRepo;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public void Create(GameDTO game)
        {
            GameRepo.Insert(mapper.Map<Game>(game));
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

        public void Edit(GameDTO game)
        {
            GameRepo.Update(mapper.Map<Game>(game));
            GameRepo.Save();
        }

        public GameDTO? Get(int id)
        {
            var game = GameRepo.GetByID(id);

            if (game == null)
                throw new HttpException(ErrorMessages.NotFound, HttpStatusCode.NotFound);

            return mapper.Map<GameDTO>(game);
        }

        public IEnumerable<GameDTO> GetAll()
        {
            var games = GameRepo.Get(includeProperties: $"{nameof(Game.Ganr)}");
            return mapper.Map<IEnumerable<GameDTO>>(games);
        }
    }
}
