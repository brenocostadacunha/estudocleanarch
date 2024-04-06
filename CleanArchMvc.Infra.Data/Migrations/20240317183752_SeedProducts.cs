using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) VALUES('Caderno', 'Caderno espiral 100 folhas', 7.45, 50, 'caderno.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) VALUES('Estojo escolar', 'Estojo escolar cinza', 3.65,  70, 'borracha.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) VALUES('Borracha', 'Borracha branca', 2.80, 100, 'borracha.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) VALUES('Caneta', 'Caneta azul', 1.75, 100, 'caneta.jpg', 1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
