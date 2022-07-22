using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV.DAL.Migrations
{
    public partial class AddLanguageProfessionalTopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LanguageProfessionalTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageProfessionalTopics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageProfessionalTopics");
        }
    }
}
