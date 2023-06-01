using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonutsNDevsAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "donutDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _ref = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    calories = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo_attribution = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donutDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "donutResults",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @ref = table.Column<string>(name: "ref", type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo_attribution = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donutResults", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Extra",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    extra = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DonutDetailsExtra",
                columns: table => new
                {
                    DonutDetails = table.Column<int>(type: "int", nullable: false),
                    Extra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonutDetailsExtra", x => new { x.DonutDetails, x.Extra });
                    table.ForeignKey(
                        name: "FK_DonutDetailsExtra_Extra_DonutDetails",
                        column: x => x.DonutDetails,
                        principalTable: "Extra",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonutDetailsExtra_donutDetails_Extra",
                        column: x => x.Extra,
                        principalTable: "donutDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonutDetailsExtra_Extra",
                table: "DonutDetailsExtra",
                column: "Extra");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonutDetailsExtra");

            migrationBuilder.DropTable(
                name: "donutResults");

            migrationBuilder.DropTable(
                name: "Extra");

            migrationBuilder.DropTable(
                name: "donutDetails");
        }
    }
}
