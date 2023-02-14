using Microsoft.EntityFrameworkCore.Migrations;

namespace DateMe.Migrations
{
    public partial class Final2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entries",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "YesNo",
                table: "Entries");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Entries",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Entries",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Entries",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Edited",
                table: "Entries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LentTo",
                table: "Entries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Entries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Entries",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Entries",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Entries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entries",
                table: "Entries",
                column: "MovieId");

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Sci-Fi", "George Lucas", false, "", "", "PG", "A New Hope", 1974 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Drama", "Francis Ford Coppola", false, "", "", "R", "The Godfather", 1970 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Romance", "Robert Zemeckis", false, "", "", "PG-13", "Forrest Gump", 1995 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entries",
                table: "Entries");

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "LentTo",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Entries");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "Entries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<byte>(
                name: "Age",
                table: "Entries",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Entries",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Entries",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "YesNo",
                table: "Entries",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entries",
                table: "Entries",
                column: "ApplicationId");
        }
    }
}
