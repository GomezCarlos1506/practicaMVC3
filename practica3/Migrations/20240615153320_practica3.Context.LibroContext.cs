using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practica3.Migrations
{
    /// <inheritdoc />
    public partial class practica3ContextLibroContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EDITORIAL",
                columns: table => new
                {
                    IDEditorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Editorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_del_contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDITORIAL", x => x.IDEditorial);
                });

            migrationBuilder.CreateTable(
                name: "INVENTARIO",
                columns: table => new
                {
                    IDinventario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLibro = table.Column<int>(type: "int", nullable: false),
                    IDSucursal = table.Column<int>(type: "int", nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVENTARIO", x => x.IDinventario);
                });

            migrationBuilder.CreateTable(
                name: "LIBRO",
                columns: table => new
                {
                    IDLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TITULO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AUTOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDEditorial = table.Column<int>(type: "int", nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    PRECIO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    COMENTARIOS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FOTO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIBRO", x => x.IDLibro);
                });

            migrationBuilder.CreateTable(
                name: "SUCURSAL",
                columns: table => new
                {
                    IDSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_del_encargado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comentario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUCURSAL", x => x.IDSucursal);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EDITORIAL");

            migrationBuilder.DropTable(
                name: "INVENTARIO");

            migrationBuilder.DropTable(
                name: "LIBRO");

            migrationBuilder.DropTable(
                name: "SUCURSAL");
        }
    }
}
