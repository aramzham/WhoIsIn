using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhoIsIn.Api.Migrations
{
    /// <inheritdoc />
    public partial class propertiesAddedToMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Matches",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Matches",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Matches",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Matches",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Matches",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Matches");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Matches",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
