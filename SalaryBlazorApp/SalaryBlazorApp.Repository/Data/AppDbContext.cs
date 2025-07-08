using Microsoft.EntityFrameworkCore;
using SalaryBlazorApp.Repository.Models;
using System;
using System.Collections.Generic;

namespace SalaryBlazorApp.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Empleado> Empleado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Sembrar (seed) datos
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 1, Title = "Liquidaciones", Order = 1 },
                new MenuItem { Id = 2, Title = "Informes", Order = 2 },
                new MenuItem { Id = 3, Title = "Archivos", Order = 3 },
                new MenuItem { Id = 4, Title = "Varios", Order = 4 },
                new MenuItem { Id = 5, Title = "Consultas", Order = 5 },
                new MenuItem { Id = 6, Title = "Ejecutar", Order = 6 },
                new MenuItem { Id = 7, Title = "Salir", Url = "/salir", Order = 7 },
                new MenuItem { Id = 8, Title = "Datos de la liquidación", Url = "/datos_liquidacion", ParentId = 4, Order = 1 },
                new MenuItem { Id = 9, Title = "Datos de la empresa", Url = "/datos_empresa", ParentId = 4, Order = 2 },
                new MenuItem { Id = 10, Title = "Parámetros", Url = "/parametros", ParentId = 4, Order = 3 },
                new MenuItem { Id = 11, Title = "Formatos de formularios", Url = "/formatos_formularios", ParentId = 4, Order = 4 },
                new MenuItem { Id = 12, Title = "Importación", ParentId = 4, Order = 5 },
                new MenuItem { Id = 13, Title = "Eliminación histórico", Url = "/eliminacion_historico", ParentId = 4, Order = 6 },
                new MenuItem { Id = 14, Title = "Impresoras", Url = "/impresoras", ParentId = 4, Order = 7 },
                new MenuItem { Id = 15, Title = "Formatos de archivos", Url = "/formatos_archivos", ParentId = 12, Order = 1 },
                new MenuItem { Id = 16, Title = "Listado de formatos", Url = "/listado_formatos", ParentId = 12, Order = 2 },
                new MenuItem { Id = 17, Title = "Definición de sinónimos", Url = "/definicion_sinonimos", ParentId = 12, Order = 3 },
                new MenuItem { Id = 18, Title = "Listado de sinónimos", Url = "/listado_sinonimos", ParentId = 12, Order = 4 },
                new MenuItem { Id = 19, Title = "Importación de archivos", Url = "/importacion_archivos", ParentId = 12, Order = 5 },
                new MenuItem { Id = 20, Title = "Legajos", ParentId = 3, Order = 1 },
                new MenuItem { Id = 21, Title = "Datos para SICOSS", ParentId = 3, Order = 2 },
                new MenuItem { Id = 22, Title = "Conceptos", ParentId = 3, Order = 3 },
                new MenuItem { Id = 23, Title = "Grupos de conceptos", Url = "/grupos_conceptos", ParentId = 3, Order = 4 },
                new MenuItem { Id = 24, Title = "Reparticiones", Url = "/reparticiones", ParentId = 3, Order = 5 },
                new MenuItem { Id = 25, Title = "Convenios", ParentId = 3, Order = 6 },
                new MenuItem { Id = 26, Title = "Centros de costos", Url = "/centro_costos", ParentId = 3, Order = 7 },
                new MenuItem { Id = 27, Title = "Sectores", Url = "/sectores", ParentId = 3, Order = 8 },
                new MenuItem { Id = 28, Title = "Referencias contables", Url = "/referencias_contables", ParentId = 3, Order = 9 },
                new MenuItem { Id = 29, Title = "Impuesto a las ganacias", ParentId = 3, Order = 10 },
                new MenuItem { Id = 30, Title = "Billetes y monedas", Url = "/billetes_monedas", ParentId = 3, Order = 11 },
                new MenuItem { Id = 31, Title = "Datos operativos", Url = "/datos_operativos", ParentId = 20, Order = 1 },
                new MenuItem { Id = 32, Title = "Datos generales", Url = "/datos_generales", ParentId = 20, Order = 2 },
                new MenuItem { Id = 33, Title = "Datos para SICOSS", Url = "/datos_sicoss", ParentId = 20, Order = 3 },
                new MenuItem { Id = 34, Title = "Acumulados mensuales", Url = "/acum_mensuales", ParentId = 20, Order = 4 },
                new MenuItem { Id = 35, Title = "Acumulados anuales", Url = "/acum_anuales", ParentId = 20, Order = 5 },
                new MenuItem { Id = 36, Title = "Imp. a las ganacias", ParentId = 20, Order = 6 },
                new MenuItem { Id = 37, Title = "Familiares", Url = "/familiares", ParentId = 20, Order = 7 },
                new MenuItem { Id = 38, Title = "Reparticiones", ParentId = 20, Order = 8 }
            );
        }
    }
}
