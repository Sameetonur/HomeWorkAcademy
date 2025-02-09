using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonelApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonType = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Email", "GroupId", "Name", "PersonType", "Surname" },
                values: new object[,]
                {
                    { 1, "samet@gmail.com", null, "Samet", 0, "Önür" },
                    { 2, "samet@gmail.com", null, "Elif", 0, "Binici" },
                    { 3, "samet@gmail.com", null, "Aleyna", 0, "Çelen" },
                    { 4, "samet@gmail.com", null, "Burhan", 0, "Torun" },
                    { 5, "samet@gmail.com", null, "Emre", 0, "Kılıç" },
                    { 6, "samet@gmail.com", null, "Doğukhan", 0, "Babayiğit" },
                    { 7, "samet@gmail.com", null, "Kerem", 0, "Kırpar" },
                    { 8, "samet@gmail.com", null, "Burak", 0, "Avar" },
                    { 9, "samet@gmail.com", null, "Enes", 0, "Aydemir" },
                    { 10, "samet@gmail.com", null, "Emin", 0, "Demir" },
                    { 11, "samet@gmail.com", null, "Bedirhan", 0, "---" },
                    { 12, "samet@gmail.com", null, "Yücel", 0, "---" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GroupId",
                table: "Persons",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
