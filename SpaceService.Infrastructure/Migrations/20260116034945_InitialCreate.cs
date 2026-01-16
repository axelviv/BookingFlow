using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Space");

            migrationBuilder.CreateTable(
                name: "Spaces",
                schema: "Space",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaces", x => x.Id);
                    table.CheckConstraint("CK_Space_Capacity", "[Capacity] > 0");
                    table.CheckConstraint("CK_Space_Price", "[Price] >= 0");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_IsActive",
                schema: "Space",
                table: "Spaces",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_Name",
                schema: "Space",
                table: "Spaces",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_Type",
                schema: "Space",
                table: "Spaces",
                column: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spaces",
                schema: "Space");
        }
    }
}
