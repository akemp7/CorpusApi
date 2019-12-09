using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CorpusApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CorpusApi",
                columns: table => new
                {
                    CorpusId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorpusApi", x => x.CorpusId);
                });

            migrationBuilder.InsertData(
                table: "CorpusApi",
                columns: new[] { "CorpusId", "Summary" },
                values: new object[] { 1, "This is a summary" });

            migrationBuilder.InsertData(
                table: "CorpusApi",
                columns: new[] { "CorpusId", "Summary" },
                values: new object[] { 2, "This is another summary" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorpusApi");
        }
    }
}
