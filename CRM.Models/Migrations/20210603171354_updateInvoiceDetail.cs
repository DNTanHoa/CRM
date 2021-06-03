using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Models.Migrations
{
    public partial class updateInvoiceDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_InvoiceDetailFunction_functioncode",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Unit_unitcode",
                table: "InvoiceDetails");

            migrationBuilder.RenameColumn(
                name: "unitcode",
                table: "InvoiceDetails",
                newName: "unitCode");

            migrationBuilder.RenameColumn(
                name: "functioncode",
                table: "InvoiceDetails",
                newName: "functionCode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_unitcode",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_unitCode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_functioncode",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_functionCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 102, DateTimeKind.Local).AddTicks(4470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 102, DateTimeKind.Local).AddTicks(3838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 100, DateTimeKind.Local).AddTicks(91),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 99, DateTimeKind.Local).AddTicks(9606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.AlterColumn<string>(
                name: "lastNumber",
                table: "SequenceNumber",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                defaultValue: "000000000",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SequenceNumber",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 96, DateTimeKind.Local).AddTicks(127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 689, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SequenceNumber",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 95, DateTimeKind.Local).AddTicks(9485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 688, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 93, DateTimeKind.Local).AddTicks(9146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 93, DateTimeKind.Local).AddTicks(8501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 91, DateTimeKind.Local).AddTicks(1958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 91, DateTimeKind.Local).AddTicks(1347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 87, DateTimeKind.Local).AddTicks(9886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 87, DateTimeKind.Local).AddTicks(9171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 85, DateTimeKind.Local).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 85, DateTimeKind.Local).AddTicks(2485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 82, DateTimeKind.Local).AddTicks(2436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 82, DateTimeKind.Local).AddTicks(1252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 79, DateTimeKind.Local).AddTicks(4980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 79, DateTimeKind.Local).AddTicks(4445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 66, DateTimeKind.Local).AddTicks(5049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 66, DateTimeKind.Local).AddTicks(4430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.AddColumn<string>(
                name: "functionName",
                table: "InvoiceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "unitName",
                table: "InvoiceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 75, DateTimeKind.Local).AddTicks(6763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 75, DateTimeKind.Local).AddTicks(5879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 55, DateTimeKind.Local).AddTicks(9705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 55, DateTimeKind.Local).AddTicks(9099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 62, DateTimeKind.Local).AddTicks(8104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 62, DateTimeKind.Local).AddTicks(7525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 52, DateTimeKind.Local).AddTicks(7482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 52, DateTimeKind.Local).AddTicks(6928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 990, DateTimeKind.Local).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 990, DateTimeKind.Local).AddTicks(5411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 988, DateTimeKind.Local).AddTicks(3163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 988, DateTimeKind.Local).AddTicks(2455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 983, DateTimeKind.Local).AddTicks(5186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 983, DateTimeKind.Local).AddTicks(4183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 970, DateTimeKind.Local).AddTicks(8792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 627, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 963, DateTimeKind.Local).AddTicks(7375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 623, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_InvoiceDetailFunction_functionCode",
                table: "InvoiceDetails",
                column: "functionCode",
                principalTable: "InvoiceDetailFunction",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Unit_unitCode",
                table: "InvoiceDetails",
                column: "unitCode",
                principalTable: "Unit",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_InvoiceDetailFunction_functionCode",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Unit_unitCode",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "functionName",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "unitName",
                table: "InvoiceDetails");

            migrationBuilder.RenameColumn(
                name: "unitCode",
                table: "InvoiceDetails",
                newName: "unitcode");

            migrationBuilder.RenameColumn(
                name: "functionCode",
                table: "InvoiceDetails",
                newName: "functioncode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_unitCode",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_unitcode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_functionCode",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_functioncode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(6343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 102, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 692, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 102, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 100, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 691, DateTimeKind.Local).AddTicks(3488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 99, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.AlterColumn<string>(
                name: "lastNumber",
                table: "SequenceNumber",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true,
                oldDefaultValue: "000000000");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SequenceNumber",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 689, DateTimeKind.Local).AddTicks(185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 96, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SequenceNumber",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 688, DateTimeKind.Local).AddTicks(9850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 95, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 93, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentTerm",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 687, DateTimeKind.Local).AddTicks(4728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 93, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(9156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 91, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 685, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 91, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 87, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 683, DateTimeKind.Local).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 87, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 85, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 682, DateTimeKind.Local).AddTicks(568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 85, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 82, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 680, DateTimeKind.Local).AddTicks(3419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 82, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(7404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 79, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 678, DateTimeKind.Local).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 79, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(2238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 66, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 675, DateTimeKind.Local).AddTicks(1850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 66, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 75, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 676, DateTimeKind.Local).AddTicks(4493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 75, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 55, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLCategory",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 670, DateTimeKind.Local).AddTicks(5081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 55, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 62, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "GLAccount",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 673, DateTimeKind.Local).AddTicks(1447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 62, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(5466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 52, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 668, DateTimeKind.Local).AddTicks(4992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 54, 52, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 990, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 636, DateTimeKind.Local).AddTicks(5057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 990, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 988, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 635, DateTimeKind.Local).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 988, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(1059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 983, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 633, DateTimeKind.Local).AddTicks(674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 983, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 627, DateTimeKind.Local).AddTicks(2522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 970, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 22, 8, 54, 623, DateTimeKind.Local).AddTicks(279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 4, 0, 13, 53, 963, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_InvoiceDetailFunction_functioncode",
                table: "InvoiceDetails",
                column: "functioncode",
                principalTable: "InvoiceDetailFunction",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Unit_unitcode",
                table: "InvoiceDetails",
                column: "unitcode",
                principalTable: "Unit",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
