using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class idsCarreras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDevolucion",
                table: "Prestamos",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<string>(
                name: "CDU",
                table: "Libros",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Libristica",
                table: "Libros",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PalabrasClave",
                table: "Libros",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CDU", "Libristica", "PalabrasClave" },
                values: new object[] { "", "", "" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CDU",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "Libristica",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "PalabrasClave",
                table: "Libros");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDevolucion",
                table: "Prestamos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 14, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(453), new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 14, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 14, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(467), new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 14, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(469), new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 14, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(472), new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 14, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(474), new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaRegistracion",
                value: new DateTime(2025, 8, 31, 20, 6, 23, 968, DateTimeKind.Local).AddTicks(525));
        }
    }
}
