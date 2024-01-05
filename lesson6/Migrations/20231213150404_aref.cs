using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lesson5.Migrations
{
    /// <inheritdoc />
    public partial class aref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "plans",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planPrice = table.Column<int>(type: "int", nullable: false),
                    planLimit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plans", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "plans");
        }
    }
}
