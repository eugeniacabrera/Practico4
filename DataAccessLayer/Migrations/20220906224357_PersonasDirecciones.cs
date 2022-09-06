using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class PersonasDirecciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosPersonales",
                columns: table => new
                {
                    Id_DatosPersonales = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPersonales", x => x.Id_DatosPersonales);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id_Direccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Id_Persona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id_Direccion);
                    table.ForeignKey(
                        name: "FK_Direcciones_Personas_Id_Persona",
                        column: x => x.Id_Persona,
                        principalTable: "Personas",
                        principalColumn: "Id_Persona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id_Contacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Persona = table.Column<int>(type: "int", nullable: false),
                    Id_DatosPersonales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id_Contacto);
                    table.ForeignKey(
                        name: "FK_Contactos_DatosPersonales_Id_DatosPersonales",
                        column: x => x.Id_DatosPersonales,
                        principalTable: "DatosPersonales",
                        principalColumn: "Id_DatosPersonales",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contactos_Personas_Id_Persona",
                        column: x => x.Id_Persona,
                        principalTable: "Personas",
                        principalColumn: "Id_Persona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_Id_DatosPersonales",
                table: "Contactos",
                column: "Id_DatosPersonales");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_Id_Persona",
                table: "Contactos",
                column: "Id_Persona");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_Id_Persona",
                table: "Direcciones",
                column: "Id_Persona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "DatosPersonales");
        }
    }
}
