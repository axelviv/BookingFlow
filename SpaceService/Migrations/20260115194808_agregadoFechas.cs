using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spaceservice.Migrations
{
    /// <inheritdoc />
    public partial class agregadoFechas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Space",
                table: "Spaces",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                schema: "Space",
                table: "Spaces",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Space",
                table: "Spaces");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                schema: "Space",
                table: "Spaces");
        }
    }
}
