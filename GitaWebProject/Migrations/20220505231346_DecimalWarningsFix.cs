using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitaWebProject.Migrations
{
    public partial class DecimalWarningsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Weight",
            //    schema: "Production",
            //    table: "Product",
            //    type: "decimal(18,4)",
            //    precision: 18,
            //    scale: 4,
            //    nullable: true,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "StandardCost",
            //    schema: "Production",
            //    table: "Product",
            //    type: "decimal(18,4)",
            //    precision: 18,
            //    scale: 4,
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "ListPrice",
            //    schema: "Production",
            //    table: "Product",
            //    type: "decimal(18,4)",
            //    precision: 18,
            //    scale: 4,
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                schema: "Production",
                table: "DeletedProducts",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardCost",
                schema: "Production",
                table: "DeletedProducts",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ListPrice",
                schema: "Production",
                table: "DeletedProducts",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Weight",
            //    schema: "Production",
            //    table: "Product",
            //    type: "decimal(18,2)",
            //    nullable: true,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,4)",
            //    oldPrecision: 18,
            //    oldScale: 4,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "StandardCost",
            //    schema: "Production",
            //    table: "Product",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,4)",
            //    oldPrecision: 18,
            //    oldScale: 4);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "ListPrice",
            //    schema: "Production",
            //    table: "Product",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,4)",
            //    oldPrecision: 18,
            //    oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                schema: "Production",
                table: "DeletedProducts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardCost",
                schema: "Production",
                table: "DeletedProducts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "ListPrice",
                schema: "Production",
                table: "DeletedProducts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);
        }
    }
}
