using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonutsNDevsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToDonutExtras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonutDetailsExtra_Extra_DonutDetails",
                table: "DonutDetailsExtra");

            migrationBuilder.DropForeignKey(
                name: "FK_DonutDetailsExtra_donutDetails_Extra",
                table: "DonutDetailsExtra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Extra",
                table: "Extra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonutDetailsExtra",
                table: "DonutDetailsExtra");

            migrationBuilder.DropIndex(
                name: "IX_DonutDetailsExtra_Extra",
                table: "DonutDetailsExtra");

            migrationBuilder.RenameTable(
                name: "Extra",
                newName: "extra");

            migrationBuilder.RenameTable(
                name: "DonutDetailsExtra",
                newName: "donutDetailsExtra");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "donutDetailsExtra",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_extra",
                table: "extra",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_donutDetailsExtra",
                table: "donutDetailsExtra",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_extra",
                table: "extra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_donutDetailsExtra",
                table: "donutDetailsExtra");

            migrationBuilder.DropColumn(
                name: "id",
                table: "donutDetailsExtra");

            migrationBuilder.RenameTable(
                name: "extra",
                newName: "Extra");

            migrationBuilder.RenameTable(
                name: "donutDetailsExtra",
                newName: "DonutDetailsExtra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Extra",
                table: "Extra",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonutDetailsExtra",
                table: "DonutDetailsExtra",
                columns: new[] { "DonutDetails", "Extra" });

            migrationBuilder.CreateIndex(
                name: "IX_DonutDetailsExtra_Extra",
                table: "DonutDetailsExtra",
                column: "Extra");

            migrationBuilder.AddForeignKey(
                name: "FK_DonutDetailsExtra_Extra_DonutDetails",
                table: "DonutDetailsExtra",
                column: "DonutDetails",
                principalTable: "Extra",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonutDetailsExtra_donutDetails_Extra",
                table: "DonutDetailsExtra",
                column: "Extra",
                principalTable: "donutDetails",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
