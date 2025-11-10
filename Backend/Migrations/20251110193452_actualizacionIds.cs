using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Técnico Superior en Desarrollo de Software");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Técnico Superior en Soporte de Infraestructura en Tecnologías de la Información");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Técnico Superior en Gestión de las Organizaciones");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Técnico Superior en Enfermería");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nombre",
                value: "Profesorado de Educ. Secundaria en Cs de la Administración");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nombre",
                value: "Profesorado de Educación Inicial");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nombre",
                value: "Profesorado de Educ. Secundaria en Economía");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nombre",
                value: "Profesorado de Educación Tecnológica");

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[] { 22, false, "Tecnicatura Superior en Gestión de Energías Renovables" });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6834), new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6843), new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6846), new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6848), new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6851), new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6853), new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 16, 34, 51, 399, DateTimeKind.Local).AddTicks(6898));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Profesorado de Educación Inicial");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Profesorado de Educ. Secundaria en Cs de la Administración");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Profesorado de Educ. Secundaria en Economía");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Profesorado de Educación Tecnológica");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nombre",
                value: "Técnico Superior en Desarrollo de Software");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nombre",
                value: "Técnico Superior en Enfermería");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nombre",
                value: "Tecnicatura Superior en Gestión de Energías Renovables");

            migrationBuilder.UpdateData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nombre",
                value: "Técnico Superior en Gestión de las Organizaciones");

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[] { 9, false, "Técnico Superior en Soporte de Infraestructura en Tecnologías de la Información" });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2888), new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2900), new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2903), new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2905), new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2908), new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2911), new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaRegistracion",
                value: new DateTime(2025, 11, 10, 15, 33, 57, 247, DateTimeKind.Local).AddTicks(2971));
        }
    }
}
