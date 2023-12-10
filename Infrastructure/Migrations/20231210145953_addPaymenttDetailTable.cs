using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addPaymenttDetailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeadOfAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidityFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidityTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadOfAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    HeadOfAccountId = table.Column<int>(type: "int", nullable: false),
                    Debit = table.Column<int>(type: "int", nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_HeadOfAccount_HeadOfAccountId",
                        column: x => x.HeadOfAccountId,
                        principalTable: "HeadOfAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_HeadOfAccountId",
                table: "PaymentDetail",
                column: "HeadOfAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_PaymentId",
                table: "PaymentDetail",
                column: "PaymentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetail");

            migrationBuilder.DropTable(
                name: "HeadOfAccount");
        }
    }
}
