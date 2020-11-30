using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    HairColor = table.Column<string>(nullable: false),
                    EyeColor = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    JobTitle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adults");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
