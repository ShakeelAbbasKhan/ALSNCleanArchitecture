using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addTranslationOfficeTranslatorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TranslationOfficeTranslators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslatorID = table.Column<int>(type: "int", nullable: false),
                    TranslationOfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationOfficeTranslators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslationOfficeTranslators_AspNetUsers_TranslationOfficeId",
                        column: x => x.TranslationOfficeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslationOfficeTranslators_Translators_TranslatorID",
                        column: x => x.TranslatorID,
                        principalTable: "Translators",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TranslationOfficeTranslators_TranslationOfficeId",
                table: "TranslationOfficeTranslators",
                column: "TranslationOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslationOfficeTranslators_TranslatorID",
                table: "TranslationOfficeTranslators",
                column: "TranslatorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranslationOfficeTranslators");
        }
    }
}
