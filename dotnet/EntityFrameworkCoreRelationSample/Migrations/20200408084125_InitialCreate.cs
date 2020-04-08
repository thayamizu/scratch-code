using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreRelationSample.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Contents = table.Column<string>(nullable: true),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Blog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Title", "Url", "isActive" },
                values: new object[] { 1, "ブログ村1", "https://xxx.yyy.zzz", true });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Title", "Url", "isActive" },
                values: new object[] { 2, "ブログ村2", "https://aaa.bbb.ccc", true });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Title", "Url", "isActive" },
                values: new object[] { 3, "ブログ村3", "https://ddd.eee.fff", false });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "BlogId", "Contents", "Title" },
                values: new object[] { 1, 1, "foobar", "エントリ" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "BlogId", "Contents", "Title" },
                values: new object[] { 2, 1, "hogehoge", "エントリ" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "BlogId", "Contents", "Title" },
                values: new object[] { 3, 2, "piyopiyo", "エントリ" });

            migrationBuilder.CreateIndex(
                name: "IX_Post_BlogId",
                table: "Post",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Blog");
        }
    }
}
