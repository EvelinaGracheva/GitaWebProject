using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitaWebProject.Migrations
{
    public partial class FixIntToShort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<short>(
            //    name: "SafetyStockLevel",
            //    schema: "Production",
            //    table: "Product",
            //    type: "smallint",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            //migrationBuilder.AlterColumn<short>(
            //    name: "ReorderPoint",
            //    schema: "Production",
            //    table: "Product",
            //    type: "smallint",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "SafetyStockLevel",
                schema: "Production",
                table: "DeletedProducts",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "ReorderPoint",
                schema: "Production",
                table: "DeletedProducts",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<int>(
            //    name: "SafetyStockLevel",
            //    schema: "Production",
            //    table: "Product",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(short),
            //    oldType: "smallint");

            //migrationBuilder.AlterColumn<int>(
            //    name: "ReorderPoint",
            //    schema: "Production",
            //    table: "Product",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(short),
            //    oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "SafetyStockLevel",
                schema: "Production",
                table: "DeletedProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "ReorderPoint",
                schema: "Production",
                table: "DeletedProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}
