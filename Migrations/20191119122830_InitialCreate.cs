using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLibrary.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BookEdition = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    BookAuthor1 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BookAuthor2 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BookCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BookPurchasePrice = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    BookPublisher = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BookISBN = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BookStatus = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BookStorage_Code = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BookStorage_Type = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
