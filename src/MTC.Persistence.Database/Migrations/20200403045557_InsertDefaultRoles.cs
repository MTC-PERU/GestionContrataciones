using Microsoft.EntityFrameworkCore.Migrations;

namespace MTC.Persistence.Database.Migrations
{
    public partial class InsertDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "78155ba8-3054-45dd-81e7-19410c9e60ed", "41ad566e-84a8-48c8-8fb7-6a1930450f6d", "ApplicationRole", "Admin", "Admin" },
                    { "4cbf5229-47ef-4308-a95e-d1c2655ace5b", "fa9a7346-e230-4546-8f98-3887cd72b1bb", "ApplicationRole", "Coordinator", "Coordinator" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cbf5229-47ef-4308-a95e-d1c2655ace5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78155ba8-3054-45dd-81e7-19410c9e60ed");
        }
    }
}
