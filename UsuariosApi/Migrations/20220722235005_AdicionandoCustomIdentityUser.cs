using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class AdicionandoCustomIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "5aebfbd6-f65b-4c64-87d4-8fbf7a02bb3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "39ce4abc-23bf-4e2a-88f3-e248357e6069");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c90a2b17-afa8-4961-afa8-00d0bdbe178d", "AQAAAAEAACcQAAAAEP379WpfYxb364+Q+eweNdV4jMLqVw1OuNBEoc0LGMs5kDzfD6oR5yzjFheVmjcxpg==", "4076f049-63b2-40e8-a2e5-0e29dc74e361" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "7da89a2b-4005-4b83-bbbd-52bace69333c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "a8ff7ccc-0b2d-4dee-8180-572ee77d8c75");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cab7bd78-68b7-4619-8329-b7bd9cbc67f4", "AQAAAAEAACcQAAAAEDAmgkNzH5guEG8cD65WOWTSAat/MmFgvFRHcZHwPlpTApxP4QnA9jdWfTXM4AOVlw==", "744e6393-34ca-4375-9b0b-5c5974740c5a" });
        }
    }
}
