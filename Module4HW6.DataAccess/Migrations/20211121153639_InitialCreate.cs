using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module4HW6.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "date", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Song_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    ArtistSongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => x.ArtistSongId);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "DateOfBirth", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "artist1@outlook.com", "https://www.instagram.com/artist1", "Artist 1", "380961234567" },
                    { 2, new DateTime(1990, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "artist2@outlook.com", "https://www.instagram.com/artist2", "Artist 2", "380661234567" },
                    { 3, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "artist3@outlook.com", "https://www.instagram.com/artist3", "Artist 3", "380963456789" },
                    { 4, new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "artist4@outlook.com", "https://www.instagram.com/artist4", "Artist 4", "380663456789" },
                    { 5, new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "artist5@outlook.com", "https://www.instagram.com/artist5", "Artist 5", "380555555555" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Title" },
                values: new object[,]
                {
                    { 1, "Genre 1" },
                    { 2, "Genre 2" },
                    { 3, "Genre 3" },
                    { 4, "Genre 4" },
                    { 5, "Genre 5" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[] { 10, 270, 0, new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 10" });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "ArtistSongId", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 10, 5, 10 },
                    { 19, 4, 10 }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, 180, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 1" },
                    { 6, 230, 1, new DateTime(2015, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 6" },
                    { 7, 240, 1, new DateTime(2015, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 7" },
                    { 2, 190, 2, new DateTime(2015, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 2" },
                    { 8, 250, 2, new DateTime(2015, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 8" },
                    { 3, 200, 3, new DateTime(2015, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 3" },
                    { 9, 260, 3, new DateTime(2015, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 9" },
                    { 4, 210, 4, new DateTime(2015, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 4" },
                    { 5, 220, 5, new DateTime(2015, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song 5" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "ArtistSongId", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 17, 2, 4 },
                    { 15, 1, 4 },
                    { 4, 4, 4 },
                    { 9, 4, 9 },
                    { 16, 1, 3 },
                    { 14, 2, 3 },
                    { 3, 3, 3 },
                    { 20, 5, 8 },
                    { 8, 3, 8 },
                    { 13, 3, 2 },
                    { 2, 2, 2 },
                    { 7, 2, 7 },
                    { 6, 1, 6 },
                    { 12, 4, 1 },
                    { 11, 5, 1 },
                    { 18, 3, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_ArtistId",
                table: "ArtistSong",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongId",
                table: "ArtistSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
