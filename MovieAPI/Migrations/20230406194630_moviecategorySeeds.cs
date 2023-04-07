using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieAPI.Migrations
{
    public partial class moviecategorySeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8461), 1, "Action" },
                    { 2, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8463), 1, "Animation" },
                    { 3, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8464), 1, "Crimen" },
                    { 4, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8466), 1, "Comedy" },
                    { 5, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8467), 1, "Documentary" },
                    { 6, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8469), 1, "Drama" },
                    { 7, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8470), 1, "Fantasy" },
                    { 8, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8472), 1, "Horror" },
                    { 9, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8473), 1, "Musical" },
                    { 10, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8475), 1, "Romance" },
                    { 11, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8477), 1, "Scary" },
                    { 12, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8478), 1, "Science fiction" },
                    { 13, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8480), 1, "Thriller" },
                    { 14, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8481), 1, "War" },
                    { 15, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8483), 1, "Western" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "MovieName", "Poster", "ReleaseYear", "Synopsis" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8526), 1, "Everything Everywhere All at Once", null, 2022, "An aging Chinese immigrant is swept up in an insane adventure, where she alone can save what's important to her by connecting with the lives she could have led in other universes." },
                    { 2, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8529), 1, "John Wick", null, 2014, "Ex-hitman John Wick comes out of retirement to track down the gangsters that took everything from him." },
                    { 3, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8531), 1, "All Quiet on the Western Front", null, 2022, "Full of excitement and patriotic fervour, the boys enthusiastically march into a war they believe in. But once on the Western Front, they discover the soul-destroying horror of World War I." },
                    { 4, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8534), 1, "Harry Potter and the Philosopher's Stone", null, 2001, "Harry Potter has lived under the stairs at his aunt and uncle's house his whole life. But on his 11th birthday, he learns he's a powerful wizard—with a place waiting for him at the Hogwarts School of Witchcraft and Wizardry." },
                    { 5, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8536), 1, "Citizen Kane", null, 1941, "Newspaper magnate, Charles Foster Kane is taken from his mother as a boy and made the ward of a rich industrialist. As a result, every well-meaning, tyrannical or self-destructive move he makes for the rest of his life appears in some way to be a reaction to that deeply wounding event." },
                    { 6, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8538), 1, "Spider-Man: Into the Spider-Verse", null, 2018, "Miles Morales is juggling his life between being a high school student and being Spider-Man. However, when Wilson \"Kingpin\" Fisk uses a super collider, another Spider-Man from another dimension, Peter Parker, accidentally winds up in Miles' dimension." },
                    { 7, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8541), 1, "La La Land", null, 2016, "Mia, an aspiring actress, serves lattes to movie stars in between auditions and Sebastian, a jazz musician, scrapes by playing cocktail party gigs in dingy bars, but as success mounts they are faced with decisions that begin to fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart." },
                    { 8, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8543), 1, "Guillermo del Toro's Pinocchio", null, 2022, "During the rise of fascism in Mussolini's Italy, a wooden boy brought magically to life struggles to live up to his father's expectations." },
                    { 9, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8545), 1, "The Secret Life of Walter Mitty", null, 2013, "A timid magazine photo manager who lives life vicariously through daydreams embarks on a true-life adventure when a negative goes missing." },
                    { 10, new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8547), 1, "Kill Bill: Vol. 1", null, 2003, "An assassin is shot by her ruthless employer, Bill, and other members of their assassination circle – but she lives to plot her vengeance." }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8319), new byte[] { 148, 46, 145, 36, 88, 17, 91, 178, 110, 69, 186, 12, 188, 97, 8, 3, 1, 31, 197, 198, 244, 174, 56, 236, 144, 101, 222, 136, 252, 91, 39, 34, 190, 37, 45, 89, 218, 199, 197, 74, 174, 104, 210, 67, 32, 77, 156, 120, 65, 95, 113, 71, 132, 110, 5, 151, 224, 239, 10, 147, 3, 176, 165, 185 }, new byte[] { 151, 206, 75, 119, 206, 252, 183, 102, 240, 116, 76, 114, 10, 8, 127, 197, 134, 98, 147, 226, 188, 161, 226, 122, 177, 46, 140, 228, 57, 24, 158, 0, 54, 208, 227, 230, 186, 54, 96, 97, 27, 43, 167, 92, 32, 35, 12, 19, 253, 157, 205, 74, 57, 199, 79, 66, 65, 204, 149, 7, 16, 219, 74, 145, 132, 153, 139, 227, 186, 183, 115, 75, 112, 225, 73, 135, 84, 127, 239, 105, 36, 77, 108, 254, 150, 165, 37, 93, 243, 102, 243, 255, 157, 209, 11, 14, 9, 183, 254, 0, 253, 222, 181, 145, 68, 30, 118, 65, 120, 95, 244, 60, 90, 155, 228, 1, 236, 191, 143, 243, 100, 65, 36, 144, 168, 230, 127, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 4, 6, 19, 46, 29, 614, DateTimeKind.Utc).AddTicks(8402), new byte[] { 131, 158, 192, 233, 66, 52, 139, 248, 7, 214, 86, 65, 231, 101, 84, 48, 143, 22, 145, 201, 42, 20, 174, 58, 55, 18, 112, 206, 168, 46, 137, 30, 64, 149, 191, 212, 22, 5, 228, 214, 116, 40, 49, 186, 90, 118, 27, 254, 38, 87, 18, 26, 174, 72, 239, 0, 39, 66, 156, 101, 112, 246, 112, 168 }, new byte[] { 44, 202, 73, 100, 238, 44, 0, 60, 234, 194, 43, 171, 67, 56, 60, 180, 97, 66, 44, 23, 230, 173, 96, 167, 162, 190, 41, 103, 185, 88, 125, 38, 111, 31, 164, 62, 200, 251, 5, 137, 161, 165, 209, 221, 29, 73, 54, 170, 245, 153, 216, 123, 86, 0, 56, 235, 3, 73, 190, 128, 224, 29, 5, 95, 109, 97, 0, 24, 143, 249, 29, 17, 117, 130, 176, 255, 72, 119, 32, 80, 231, 204, 187, 176, 241, 114, 49, 211, 182, 156, 34, 163, 206, 182, 235, 75, 8, 42, 255, 22, 132, 247, 218, 229, 66, 237, 102, 153, 90, 24, 250, 220, 109, 20, 97, 105, 242, 249, 244, 128, 102, 62, 208, 255, 59, 245, 70, 127 } });

            migrationBuilder.InsertData(
                table: "CategoryMovie",
                columns: new[] { "CategoriesId", "MoviesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 6 },
                    { 1, 9 },
                    { 1, 10 },
                    { 2, 6 },
                    { 2, 8 },
                    { 3, 10 },
                    { 4, 1 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 9 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 6 },
                    { 7, 8 },
                    { 7, 9 },
                    { 9, 7 },
                    { 10, 7 },
                    { 10, 9 },
                    { 13, 2 },
                    { 14, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryMovie",
                keyColumns: new[] { "CategoriesId", "MoviesId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 4, 6, 19, 43, 20, 648, DateTimeKind.Utc).AddTicks(4626), new byte[] { 38, 201, 73, 111, 143, 38, 8, 81, 152, 227, 225, 249, 142, 160, 74, 224, 53, 167, 36, 160, 220, 81, 76, 99, 187, 43, 36, 232, 238, 67, 167, 13, 45, 247, 105, 186, 149, 246, 201, 251, 111, 165, 24, 207, 96, 173, 144, 234, 230, 62, 149, 172, 8, 193, 139, 169, 164, 255, 41, 166, 90, 206, 252, 42 }, new byte[] { 10, 55, 174, 159, 174, 50, 150, 118, 94, 201, 191, 241, 189, 63, 168, 191, 250, 110, 121, 148, 136, 142, 126, 76, 143, 221, 93, 81, 46, 83, 168, 251, 194, 84, 29, 149, 188, 133, 169, 17, 243, 118, 148, 241, 181, 119, 53, 6, 106, 141, 80, 18, 207, 215, 133, 132, 156, 156, 49, 213, 12, 239, 58, 237, 171, 31, 243, 81, 233, 104, 46, 87, 21, 46, 12, 117, 143, 58, 212, 229, 212, 7, 146, 215, 195, 181, 115, 223, 34, 16, 147, 237, 30, 222, 42, 11, 239, 25, 223, 139, 127, 6, 53, 183, 61, 89, 250, 139, 74, 94, 97, 30, 56, 132, 116, 4, 109, 70, 228, 169, 216, 78, 190, 172, 108, 178, 213, 210 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 4, 6, 19, 43, 20, 648, DateTimeKind.Utc).AddTicks(4676), new byte[] { 203, 54, 179, 215, 99, 46, 240, 243, 186, 245, 13, 227, 232, 4, 76, 123, 241, 194, 107, 112, 208, 229, 205, 39, 92, 3, 249, 180, 211, 108, 66, 146, 74, 43, 38, 208, 75, 220, 84, 54, 185, 230, 15, 101, 217, 153, 27, 132, 253, 127, 221, 65, 102, 158, 27, 133, 78, 166, 66, 68, 247, 133, 111, 161 }, new byte[] { 205, 103, 239, 62, 218, 231, 131, 19, 141, 220, 94, 223, 76, 238, 224, 87, 218, 217, 177, 191, 25, 179, 83, 115, 229, 121, 15, 199, 210, 47, 137, 113, 67, 195, 208, 47, 52, 189, 228, 76, 22, 121, 92, 124, 254, 143, 252, 136, 34, 244, 79, 148, 138, 159, 12, 0, 203, 26, 218, 10, 202, 87, 235, 67, 12, 218, 199, 184, 100, 233, 117, 81, 66, 158, 137, 43, 246, 70, 213, 74, 138, 182, 87, 26, 21, 126, 14, 90, 120, 124, 17, 21, 68, 90, 187, 35, 255, 180, 100, 96, 219, 250, 117, 8, 16, 166, 230, 121, 3, 148, 133, 76, 196, 238, 109, 32, 61, 120, 123, 36, 144, 35, 135, 172, 83, 47, 217, 229 } });
        }
    }
}
