using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonAPI.Infra.Data.Migrations
{
    public partial class SeedingExtensionMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedAt", "Name", "TrainerClass", "UpdatedAt" },
                values: new object[] { new Guid("ec15f996-4289-4f8c-bd16-1bb3b9817042"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ash Ketchum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedAt", "Name", "TrainerClass", "UpdatedAt" },
                values: new object[] { new Guid("7f2d617a-75be-4f03-85ad-3148ddfefea3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("7f2d617a-75be-4f03-85ad-3148ddfefea3"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ec15f996-4289-4f8c-bd16-1bb3b9817042"));
        }
    }
}
