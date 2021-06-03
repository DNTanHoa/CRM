using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Models.Migrations
{
    public partial class addSequenceNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(6343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 342, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(4728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 342, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(9156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 335, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 335, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(7404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(2238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(1850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 326, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 325, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 328, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 328, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(5466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(4992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(1059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 627, DateTimeKind.Local).AddTicks(2522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 281, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 623, DateTimeKind.Local).AddTicks(279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 277, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.CreateTable(
                name: "SequenceNumber",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prefix = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValue: ""),
                    subfix = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValue: ""),
                    partern = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValue: ""),
                    serial = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValue: ""),
                    numberFrom = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValue: "000000000"),
                    numberTo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValue: "999999999"),
                    lastNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 688, DateTimeKind.Local).AddTicks(9850)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 689, DateTimeKind.Local).AddTicks(185))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SequenceNumber", x => x.id);
                    table.ForeignKey(
                        name: "FK_SequenceNumber_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SequenceNumber_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SequenceNumber_CreateByusername",
                table: "SequenceNumber",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_SequenceNumber_UpdateByusername",
                table: "SequenceNumber",
                column: "UpdateByusername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SequenceNumber");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 342, DateTimeKind.Local).AddTicks(8626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 342, DateTimeKind.Local).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(2294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 335, DateTimeKind.Local).AddTicks(7781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 335, DateTimeKind.Local).AddTicks(7455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(7084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(6639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(9405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(8942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 326, DateTimeKind.Local).AddTicks(139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 325, DateTimeKind.Local).AddTicks(9791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 328, DateTimeKind.Local).AddTicks(6551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 328, DateTimeKind.Local).AddTicks(6228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 281, DateTimeKind.Local).AddTicks(7113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 627, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 277, DateTimeKind.Local).AddTicks(5175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 623, DateTimeKind.Local).AddTicks(279));
        }
    }
}
