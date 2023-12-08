using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addOrderRepititionIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderRepitionID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrderRepititions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRepitionNo = table.Column<int>(type: "int", nullable: false),
                    OrderRepitionTimeLimitHrs = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRepititions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderRepitionID",
                table: "OrderDetails",
                column: "OrderRepitionID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderRepititions_OrderRepitionID",
                table: "OrderDetails",
                column: "OrderRepitionID",
                principalTable: "OrderRepititions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderRepititions_OrderRepitionID",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderRepititions");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderRepitionID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderRepitionID",
                table: "OrderDetails");
        }
    }
}
