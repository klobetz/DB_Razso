using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp_DB_Entity.Migrations
{
    /// <inheritdoc />
    public partial class user_03_userbirsthday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirsthDay",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirsthDay",
                table: "User");
        }
    }
}
