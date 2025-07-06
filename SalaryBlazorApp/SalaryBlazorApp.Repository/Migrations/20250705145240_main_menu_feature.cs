using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalaryBlazorApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class main_menu_feature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Icon", "IsActive", "Order", "ParentId", "Title", "Url" },
                values: new object[,]
                {
                    { 1, null, false, 1, 0, "Liquidaciones", "/liquidaciones" },
                    { 2, null, false, 2, 0, "Informes", "/informes" },
                    { 3, null, false, 3, 0, "Archivos", "/archivos" },
                    { 4, null, false, 4, 0, "Varios", "/varios" },
                    { 5, null, false, 5, 0, "Consultas", "/consultas" },
                    { 6, null, false, 6, 0, "Ejecutar", "/ejecutar" },
                    { 7, null, false, 7, 0, "Salir", "/salir" },
                    { 8, null, false, 1, 4, "Datos de la liquidación", "/datos_liquidacion" },
                    { 9, null, false, 2, 4, "Datos de la empresa", "/datos_empresa" },
                    { 10, null, false, 3, 4, "Parámetros", "/parametros" },
                    { 11, null, false, 4, 4, "Formatos de formularios", "/formatos_formularios" },
                    { 12, null, false, 5, 4, "Importación", "/importacion" },
                    { 13, null, false, 6, 4, "Eliminación histórico", "/eliminacion_historico" },
                    { 14, null, false, 7, 4, "Impresoras", "/impresoras" },
                    { 15, null, false, 1, 12, "Formatos de archivos", "/formatos_archivos" },
                    { 16, null, false, 2, 12, "Listado de formatos", "/listado_formatos" },
                    { 17, null, false, 3, 12, "Definición de sinónimos", "/definicion_sinonimos" },
                    { 18, null, false, 4, 12, "Listado de sinónimos", "/listado_sinonimos" },
                    { 19, null, false, 5, 12, "Importación de archivos", "/importacion_archivos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");
        }
    }
}
