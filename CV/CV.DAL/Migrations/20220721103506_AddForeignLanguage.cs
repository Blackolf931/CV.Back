using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV.DAL.Migrations
{
    public partial class AddForeignLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Expirience",
                table: "Skills",
                newName: "Experience");

            migrationBuilder.CreateTable(
                name: "ForeignLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignLanguages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForeignLanguages");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Skills",
                newName: "Expirience");
        }
    }
}
