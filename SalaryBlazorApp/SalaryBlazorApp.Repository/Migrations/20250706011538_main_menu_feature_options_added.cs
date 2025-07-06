using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalaryBlazorApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class main_menu_feature_options_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "MenuItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "ParentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "ParentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "ParentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "ParentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "ParentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "ParentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "ParentId",
                value: null);

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Icon", "IsActive", "Order", "ParentId", "Title", "Url" },
                values: new object[,]
                {
                    { 20, null, false, 1, 3, "Legajos", null },
                    { 21, null, false, 2, 3, "Datos para SICOSS", null },
                    { 22, null, false, 3, 3, "Conceptos", null },
                    { 23, null, false, 4, 3, "Grupos de conceptos", "/grupos_conceptos" },
                    { 24, null, false, 5, 3, "Reparticiones", "/reparticiones" },
                    { 25, null, false, 6, 3, "Convenios", null },
                    { 26, null, false, 7, 3, "Centros de costos", "/centro_costos" },
                    { 27, null, false, 8, 3, "Sectores", "/sectores" },
                    { 28, null, false, 9, 3, "Referencias contables", "/referencias_contables" },
                    { 29, null, false, 10, 3, "Impuesto a las ganacias", null },
                    { 30, null, false, 11, 3, "Billetes y monedas", "/billetes_monedas" },
                    { 31, null, false, 1, 20, "Datos operativos", "/datos_operativos" },
                    { 32, null, false, 2, 21, "Datos generales", "/datos_generales" },
                    { 33, null, false, 3, 22, "Datos para SICOSS", "/datos_sicoss" },
                    { 34, null, false, 4, 23, "Acumulados mensuales", "/acum_mensuales" },
                    { 35, null, false, 5, 24, "Acumulados anuales", "/acum_anuales" },
                    { 36, null, false, 6, 25, "Imp. a las ganacias", null },
                    { 37, null, false, 7, 26, "Familiares", "/familiares" },
                    { 38, null, false, 8, 27, "Reparticiones", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_ParentId",
                table: "MenuItem",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_MenuItem_ParentId",
                table: "MenuItem",
                column: "ParentId",
                principalTable: "MenuItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_MenuItem_ParentId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_ParentId",
                table: "MenuItem");

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "MenuItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "ParentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "ParentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "ParentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "ParentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "ParentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "ParentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "ParentId",
                value: 0);
        }
    }
}
