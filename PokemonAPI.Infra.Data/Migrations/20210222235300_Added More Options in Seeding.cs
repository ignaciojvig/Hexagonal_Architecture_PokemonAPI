using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonAPI.Infra.Data.Migrations
{
    public partial class AddedMoreOptionsinSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("7f2d617a-75be-4f03-85ad-3148ddfefea3"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ec15f996-4289-4f8c-bd16-1bb3b9817042"));

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "CreatedAt", "Name", "PokemonType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("827e1166-3cd5-40b4-a307-c048d34be010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulbasaur", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03a90f76-3bc6-4674-a3fc-837aeebce09b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charmander", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b02d81d-efbe-43cb-a2ba-1fb0afa83537"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Squirtle", 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedAt", "Name", "TrainerClass", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("dd89ec31-7534-44f1-9805-58b2f4ca9451"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ash Ketchum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f2d44e1-2748-47c0-a69f-864f92bbabdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("03a90f76-3bc6-4674-a3fc-837aeebce09b"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("3b02d81d-efbe-43cb-a2ba-1fb0afa83537"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("827e1166-3cd5-40b4-a307-c048d34be010"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("9f2d44e1-2748-47c0-a69f-864f92bbabdd"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("dd89ec31-7534-44f1-9805-58b2f4ca9451"));

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedAt", "Name", "TrainerClass", "UpdatedAt" },
                values: new object[] { new Guid("ec15f996-4289-4f8c-bd16-1bb3b9817042"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ash Ketchum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedAt", "Name", "TrainerClass", "UpdatedAt" },
                values: new object[] { new Guid("7f2d617a-75be-4f03-85ad-3148ddfefea3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
