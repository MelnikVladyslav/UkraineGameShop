using BusinessLogic.Entites;
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
                    Price = 1847,
                    Memory = 6,
                    Description = "Victory is at your fingertips! Your ability to lead your nation is your supreme weapon, the strategy game Hearts of Iron IV lets you take command of any nation in World War II; the most engaging conflict in world history.",
                    Logotip = @"https://upload.wikimedia.org/wikipedia/uk/thumb/6/62/%D0%9E%D0%B1%D0%BA%D0%BB%D0%B0%D0%B4%D0%B8%D0%BD%D0%BA%D0%B0_%D0%B2%D1%96%D0%B4%D0%B5%D0%BE%D0%B3%D1%80%D0%B8_Hearts_of_Iron.jpg/250px-%D0%9E%D0%B1%D0%BA%D0%BB%D0%B0%D0%B4%D0%B8%D0%BD%D0%BA%D0%B0_%D0%B2%D1%96%D0%B4%D0%B5%D0%BE%D0%B3%D1%80%D0%B8_Hearts_of_Iron.jpg"
                },
                new Game
                {
                    Id = 2,
                    Name = "CS:GO",
                    GanrId = (int)Ganrs.Shuter,
                    Price = 0,
                    Memory = 30,
                    Description = "Counter-Strike: Global Offensive (CS:GO) продовжує розвивати командний бойовий ігролад, що зробив серію успішною багато років тому. CS:GO пропонує нові мапи, персонажів, зброю, ігрові режими, а також оновлені версії класичного вмісту (de_dust2 тощо).",
                    Logotip = @"https://itc.ua/wp-content/uploads/2022/01/counter-strike-go-1200x720-1.png"
                },
                new Game
                {
                    Id = 3,
                    Name = "Cuphead",
                    GanrId = (int)Ganrs.Arcady,
                    Price = 1030,
                    Memory = 10,
                    Description = "Cuphead is a classic run and gun action game heavily focused on boss battles. Inspired by cartoons of the 1930s, the visuals and audio are painstakingly created with the same techniques of the era, i.e. traditional hand drawn cel animation, watercolor backgrounds, and original jazz recordings.",
                    Logotip = @"https://image.api.playstation.com/vulcan/img/cfn/11307fd0s0uyV-ba4dy5E9qskf6CIntl28sAerYTFbYC7vPUBrfgp7zokliHVbVoJ5ghylOBamo2Q2i5pbEYxQKFnSsiLHaY.png"
                },
                new Game
                {
                    Id = 4,
                    Name = "Rust",
                    GanrId = (int)Ganrs.Survival,
                    Price = 2335,
                    Memory = 6,
                    Description = "The only aim in Rust is to survive. Everything wants you to die - the island’s wildlife and other inhabitants, the environment, other survivors. Do whatever it takes to last another night.",
                    Logotip = @"https://static-cdn.jtvnw.net/ttv-boxart/263490_IGDB-285x380.jpg"
                },
                new Game
                {
                    Id = 5,
                    Name = "Evarlistsing Summer",
                    GanrId = (int)Ganrs.VisualNovel,
                    Price = 0,
                    Memory = 6,
                    Description = "Visual novel loved by many – Everlasting Summer – now on Steam!",
                    Logotip = @"https://images.stopgame.ru/blogs/2021/05/30/c452x252/DnsDVzmq5IEwKHixNp14uQ/A5PYl4kXy.jpg"
                },
                new Game
                {
                    Id = 6,
                    Name = "PUBG",
                    GanrId = (int)Ganrs.BattleRoyale,
                    Price = 0,
                    Memory = 3,
                    Description = "Грайте в PUBG: BATTLEGROUNDS безкоштовно. Приземляйтеся в стратегічних локаціях, грабуйте зброю та припаси та виживайте, щоб стати останньою командою, що стоїть на різних, різноманітних полях битв.",
                    Logotip = @"https://upload.wikimedia.org/wikipedia/ru/thumb/c/c9/%D0%9B%D0%BE%D0%B3%D0%BE%D1%82%D0%B8%D0%BF_%D0%B8%D0%B3%D1%80%D1%8B_PlayerUnknown%27s_Battlegrounds.jpg/640px-%D0%9B%D0%BE%D0%B3%D0%BE%D1%82%D0%B8%D0%BF_%D0%B8%D0%B3%D1%80%D1%8B_PlayerUnknown%27s_Battlegrounds.jpg"
                },
                new Game
                {
                    Id = 7,
                    Name = "Victoria III",
                    GanrId = (int)Ganrs.Strategy,
                    Price = 1399,
                    Memory = 6,
                    Description = "Paradox Development Studio invites you to build your ideal society in the tumult of the exciting and transformative 19th century. Balance the competing interests in your society and earn your place in the sun in Victoria 3, one of the most anticipated games in Paradox’s history.",
                    Logotip = @"https://cdn.cloudflare.steamstatic.com/steam/apps/529340/capsule_616x353.jpg?t=1669908756"
                },
                new Game
                {
                    Id = 8,
                    Name = "Stalker",
                    GanrId = (int)Ganrs.Shuter,
                    Price = 500,
                    Memory = 8,
                    Description = "S.T.A.L.K.E.R.: Тінь Чорнобиля розповідає про виживання в Зоні – вкрай небезпечному місці, де потрібно боятися не тільки радіації, аномалій та смертоносних істот, але й інших \"сталкерів\", котрі переслідують власні цілі.\n",
                    Logotip = @"https://images.alphatorrent.net/posts/2021-12/stalker-ten-chernobilya-poster.jpg"
                },
                new Game
                {
                    Id = 9,
                    Name = "Minecraft Dungeons",
                    GanrId = (int)Ganrs.Arcady,
                    Price = 0,
                    Memory = 6,
                    Description = "Пробийте свій шлях в абсолютно новій пригодницькій грі, натхненій класичними данжен-кроулерами, дія якої розгортається у всесвіті Minecraft!",
                    Logotip = @"https://cdn.akamai.steamstatic.com/steam/apps/1672970/capsule_616x353.jpg?t=1666102880"
                },
                new Game
                {
                    Id = 10,
                    Name = "RimWorld",
                    GanrId = (int)Ganrs.Survival,
                    Price = 0,
                    Memory = 6,
                    Description = "Науково-фантастичний симулятор колонії, керований розповідачем — розумним штучним інтелектом. \"RimWorld\" розповість історію про трьох людей, які вижили після падіння космічного лайнера та побудували колонію на краю цивілізації, в кінці розвіданого Всесвіту.",
                    Logotip = @"https://cdn.akamai.steamstatic.com/steam/apps/294100/capsule_616x353.jpg?t=1666905455"
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
                new Ganr() { Id = (int)Ganrs.Survival, Name = "Survival" },
                new Ganr() { Id = (int)Ganrs.VisualNovel, Name = "Visual Novel" },
                new Ganr() { Id = (int)Ganrs.BattleRoyale, Name = "Battle Royale" }
            });
        }
    }
}
