using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class UpdateMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 1847m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 1030m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 2335m);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GanrId", "Logotip", "Memory", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 7, "Paradox Development Studio invites you to build your ideal society in the tumult of the exciting and transformative 19th century. Balance the competing interests in your society and earn your place in the sun in Victoria 3, one of the most anticipated games in Paradox’s history.", 1, "https://cdn.cloudflare.steamstatic.com/steam/apps/529340/capsule_616x353.jpg?t=1669908756", 6, "Victoria III", null, 1399m },
                    { 8, "S.T.A.L.K.E.R.: Тінь Чорнобиля розповідає про виживання в Зоні – вкрай небезпечному місці, де потрібно боятися не тільки радіації, аномалій та смертоносних істот, але й інших \"сталкерів\", котрі переслідують власні цілі.\n", 2, "https://images.alphatorrent.net/posts/2021-12/stalker-ten-chernobilya-poster.jpg", 8, "Stalker", null, 500m },
                    { 9, "Пробийте свій шлях в абсолютно новій пригодницькій грі, натхненій класичними данжен-кроулерами, дія якої розгортається у всесвіті Minecraft!", 3, "https://cdn.akamai.steamstatic.com/steam/apps/1672970/capsule_616x353.jpg?t=1666102880", 6, "Minecraft Dungeons", null, 0m },
                    { 10, "Науково-фантастичний симулятор колонії, керований розповідачем — розумним штучним інтелектом. \"RimWorld\" розповість історію про трьох людей, які вижили після падіння космічного лайнера та побудували колонію на краю цивілізації, в кінці розвіданого Всесвіту.", 4, "https://cdn.akamai.steamstatic.com/steam/apps/294100/capsule_616x353.jpg?t=1666905455", 6, "RimWorld", null, 0m }
                });

            migrationBuilder.InsertData(
                table: "Ganrs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Visual Novel" },
                    { 6, "Battle Royale" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GanrId", "Logotip", "Memory", "Name", "OrderId", "Price" },
                values: new object[] { 5, "Visual novel loved by many – Everlasting Summer – now on Steam!", 5, "https://images.stopgame.ru/blogs/2021/05/30/c452x252/DnsDVzmq5IEwKHixNp14uQ/A5PYl4kXy.jpg", 6, "Evarlistsing Summer", null, 0m });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GanrId", "Logotip", "Memory", "Name", "OrderId", "Price" },
                values: new object[] { 6, "Грайте в PUBG: BATTLEGROUNDS безкоштовно. Приземляйтеся в стратегічних локаціях, грабуйте зброю та припаси та виживайте, щоб стати останньою командою, що стоїть на різних, різноманітних полях битв.", 6, "https://upload.wikimedia.org/wikipedia/ru/thumb/c/c9/%D0%9B%D0%BE%D0%B3%D0%BE%D1%82%D0%B8%D0%BF_%D0%B8%D0%B3%D1%80%D1%8B_PlayerUnknown%27s_Battlegrounds.jpg/640px-%D0%9B%D0%BE%D0%B3%D0%BE%D1%82%D0%B8%D0%BF_%D0%B8%D0%B3%D1%80%D1%8B_PlayerUnknown%27s_Battlegrounds.jpg", 3, "PUBG", null, 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 18475m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 10309m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 23352m);
        }
    }
}
