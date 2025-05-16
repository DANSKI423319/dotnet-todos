using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_todos.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTodoEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Todos");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Todos",
                newName: "Task");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedAt",
                table: "Todos",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Todos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Todos",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Todos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedAt",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Todos");

            migrationBuilder.RenameColumn(
                name: "Task",
                table: "Todos",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Todos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Todos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
