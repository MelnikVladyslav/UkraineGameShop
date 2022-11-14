﻿using BusinessLogic.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class SeedDataExtensions
    {
        public static void SeedGames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(new Game[]
            {
                new Game
                {
                    Id = 1,
                    Name = "Hearts of iron IV",
                    GanrId = (int)Ganrs.Strategy,
                    Price = 18475,
                    Memory = 6,
                    Logotip = @"https://upload.wikimedia.org/wikipedia/uk/thumb/6/62/%D0%9E%D0%B1%D0%BA%D0%BB%D0%B0%D0%B4%D0%B8%D0%BD%D0%BA%D0%B0_%D0%B2%D1%96%D0%B4%D0%B5%D0%BE%D0%B3%D1%80%D0%B8_Hearts_of_Iron.jpg/250px-%D0%9E%D0%B1%D0%BA%D0%BB%D0%B0%D0%B4%D0%B8%D0%BD%D0%BA%D0%B0_%D0%B2%D1%96%D0%B4%D0%B5%D0%BE%D0%B3%D1%80%D0%B8_Hearts_of_Iron.jpg"
                },
                new Game
                {
                    Id = 2,
                    Name = "CS:GO",
                    GanrId = (int)Ganrs.Shuter,
                    Price = 0,
                    Memory = 30,
                    Logotip = @"https://itc.ua/wp-content/uploads/2022/01/counter-strike-go-1200x720-1.png"
                },
                new Game
                {
                    Id = 3,
                    Name = "Cuphead",
                    GanrId = (int)Ganrs.Arcady,
                    Price = 10309,
                    Memory = 10,
                    Logotip = @"https://image.api.playstation.com/vulcan/img/cfn/11307fd0s0uyV-ba4dy5E9qskf6CIntl28sAerYTFbYC7vPUBrfgp7zokliHVbVoJ5ghylOBamo2Q2i5pbEYxQKFnSsiLHaY.png"
                },
                new Game
                {
                    Id = 4,
                    Name = "Rust",
                    GanrId = (int)Ganrs.Survival,
                    Price = 23352,
                    Memory = 6,
                    Logotip = @"https://static-cdn.jtvnw.net/ttv-boxart/263490_IGDB-285x380.jpg"
                }
            });
        }
        public static void SeedGanrs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ganr>().HasData(new Ganr[]
            {
                new Ganr() { Id = (int)Ganrs.Strategy, Name = "Strategy" },
                new Ganr() { Id = (int)Ganrs.Shuter, Name = "Shuter" },
                new Ganr() { Id = (int)Ganrs.Arcady, Name = "Arcady" },
                new Ganr() { Id = (int)Ganrs.Survival, Name = "Survival" }
            });
        }
    }
}