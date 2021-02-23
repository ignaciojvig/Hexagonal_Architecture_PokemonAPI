using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonAPI.Infra.Data.Migrations
{
    public partial class AddedStaticGUIDsforSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Pokemons",
                columns: new[] { "Id", "CreatedAt", "Name", "PokemonType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("46bcfb9b-7e9c-4a22-baeb-048262bba83a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulbasaur", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c90b614c-e10f-423a-9bcb-8b8cececacd7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charmander", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1ebe66a-d83f-4b69-ae5d-a6a8a997fdd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Squirtle", 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedAt", "Name", "TrainerClass", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("48946519-ded7-4752-92f8-67b133644631"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ash Ketchum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e7a6390-d2a2-437a-8cbf-a4d17f457abe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("46bcfb9b-7e9c-4a22-baeb-048262bba83a"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("a1ebe66a-d83f-4b69-ae5d-a6a8a997fdd1"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("c90b614c-e10f-423a-9bcb-8b8cececacd7"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("48946519-ded7-4752-92f8-67b133644631"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("8e7a6390-d2a2-437a-8cbf-a4d17f457abe"));

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
    }
}
