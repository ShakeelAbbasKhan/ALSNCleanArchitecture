using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TranslationOfficeID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TranslationOfficeID",
                table: "Orders",
                column: "TranslationOfficeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_TranslationOfficeID",
                table: "Orders",
                column: "TranslationOfficeID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_TranslationOfficeID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TranslationOfficeID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TranslationOfficeID",
                table: "Orders");
        }
    }
}
