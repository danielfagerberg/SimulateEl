using Microsoft.EntityFrameworkCore.Migrations;

namespace SimulateEl.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RealConsumptions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    Timeframe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealConsumptions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RealConsumptions");
        }
    }
}
