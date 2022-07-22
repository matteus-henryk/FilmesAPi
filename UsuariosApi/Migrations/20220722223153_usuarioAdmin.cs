using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class usuarioAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "a7a993c6-0d86-45a9-94fe-cb7969182c2b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a513b4f6-d812-430a-8da1-a3f971562e74", "AQAAAAEAACcQAAAAEOVZZ1kACKQj4Y6Mr1pdNN+MpkNfbWwl3CUX+HG8drMy1kwlepr9wy0Fev6XJziXsw==", "d2bfddb5-515e-4988-b5bc-0def894ccafc" });
        }
    }
}
