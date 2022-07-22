using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class CriandoRoleRegular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "a8ff7ccc-0b2d-4dee-8180-572ee77d8c75");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "7da89a2b-4005-4b83-bbbd-52bace69333c", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cab7bd78-68b7-4619-8329-b7bd9cbc67f4", "AQAAAAEAACcQAAAAEDAmgkNzH5guEG8cD65WOWTSAat/MmFgvFRHcZHwPlpTApxP4QnA9jdWfTXM4AOVlw==", "744e6393-34ca-4375-9b0b-5c5974740c5a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "1883b911-6cba-449c-9633-c7c7ad4ff986");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3ae5ff8-c20a-4906-93cb-d61dc136a932", "AQAAAAEAACcQAAAAEL1sBQsWPrQJqhesK5P9CN48H3GpRn1WSst5PQ8zCIRR/a5+nSOGMTg8ARkepVSouw==", "acf186a6-5ca6-4190-87e1-8e3085028921" });
        }
    }
}
