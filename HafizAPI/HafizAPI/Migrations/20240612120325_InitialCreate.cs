using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HafizApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surahs",
                columns: table => new
                {
                    SurahID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfAyat = table.Column<int>(type: "int", nullable: false),
                    SurahName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surahs", x => x.SurahID);
                });

            migrationBuilder.CreateTable(
                name: "Ayat",
                columns: table => new
                {
                    AyahID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AyahNumber = table.Column<int>(type: "int", nullable: false),
                    AyahText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurahNumberID = table.Column<int>(type: "int", nullable: false),
                    SurahID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayat", x => x.AyahID);
                    table.ForeignKey(
                        name: "FK_Ayat_Surahs_SurahID",
                        column: x => x.SurahID,
                        principalTable: "Surahs",
                        principalColumn: "SurahID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ayat_SurahID",
                table: "Ayat",
                column: "SurahID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ayat");

            migrationBuilder.DropTable(
                name: "Surahs");
        }
    }
}
