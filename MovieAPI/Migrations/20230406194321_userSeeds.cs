using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieAPI.Migrations
{
    public partial class userSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 19, 43, 20, 648, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 19, 43, 20, 648, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 6, 19, 43, 20, 648, DateTimeKind.Utc).AddTicks(4626), "admin@ravn.com", "El", "Admin", new byte[] { 38, 201, 73, 111, 143, 38, 8, 81, 152, 227, 225, 249, 142, 160, 74, 224, 53, 167, 36, 160, 220, 81, 76, 99, 187, 43, 36, 232, 238, 67, 167, 13, 45, 247, 105, 186, 149, 246, 201, 251, 111, 165, 24, 207, 96, 173, 144, 234, 230, 62, 149, 172, 8, 193, 139, 169, 164, 255, 41, 166, 90, 206, 252, 42 }, new byte[] { 10, 55, 174, 159, 174, 50, 150, 118, 94, 201, 191, 241, 189, 63, 168, 191, 250, 110, 121, 148, 136, 142, 126, 76, 143, 221, 93, 81, 46, 83, 168, 251, 194, 84, 29, 149, 188, 133, 169, 17, 243, 118, 148, 241, 181, 119, 53, 6, 106, 141, 80, 18, 207, 215, 133, 132, 156, 156, 49, 213, 12, 239, 58, 237, 171, 31, 243, 81, 233, 104, 46, 87, 21, 46, 12, 117, 143, 58, 212, 229, 212, 7, 146, 215, 195, 181, 115, 223, 34, 16, 147, 237, 30, 222, 42, 11, 239, 25, 223, 139, 127, 6, 53, 183, 61, 89, 250, 139, 74, 94, 97, 30, 56, 132, 116, 4, 109, 70, 228, 169, 216, 78, 190, 172, 108, 178, 213, 210 }, 1 },
                    { 2, new DateTime(2023, 4, 6, 19, 43, 20, 648, DateTimeKind.Utc).AddTicks(4676), "userDavid@ravn.com", "David", "Peres", new byte[] { 203, 54, 179, 215, 99, 46, 240, 243, 186, 245, 13, 227, 232, 4, 76, 123, 241, 194, 107, 112, 208, 229, 205, 39, 92, 3, 249, 180, 211, 108, 66, 146, 74, 43, 38, 208, 75, 220, 84, 54, 185, 230, 15, 101, 217, 153, 27, 132, 253, 127, 221, 65, 102, 158, 27, 133, 78, 166, 66, 68, 247, 133, 111, 161 }, new byte[] { 205, 103, 239, 62, 218, 231, 131, 19, 141, 220, 94, 223, 76, 238, 224, 87, 218, 217, 177, 191, 25, 179, 83, 115, 229, 121, 15, 199, 210, 47, 137, 113, 67, 195, 208, 47, 52, 189, 228, 76, 22, 121, 92, 124, 254, 143, 252, 136, 34, 244, 79, 148, 138, 159, 12, 0, 203, 26, 218, 10, 202, 87, 235, 67, 12, 218, 199, 184, 100, 233, 117, 81, 66, 158, 137, 43, 246, 70, 213, 74, 138, 182, 87, 26, 21, 126, 14, 90, 120, 124, 17, 21, 68, 90, 187, 35, 255, 180, 100, 96, 219, 250, 117, 8, 16, 166, 230, 121, 3, 148, 133, 76, 196, 238, 109, 32, 61, 120, 123, 36, 144, 35, 135, 172, 83, 47, 217, 229 }, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 19, 42, 47, 364, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 19, 42, 47, 364, DateTimeKind.Utc).AddTicks(5213));
        }
    }
}
