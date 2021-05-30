using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Models.Migrations
{
    public partial class alterDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 611, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(7686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 610, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(4953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(3257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(2862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(8953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(2182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 602, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(1767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 601, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(9206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(8793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 578, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 577, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 926, DateTimeKind.Local).AddTicks(3212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 532, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 921, DateTimeKind.Local).AddTicks(6886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 528, DateTimeKind.Local).AddTicks(7807));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 611, DateTimeKind.Local).AddTicks(303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 610, DateTimeKind.Local).AddTicks(9958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(9186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(8787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(6142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(5801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(3323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(2978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 602, DateTimeKind.Local).AddTicks(318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 601, DateTimeKind.Local).AddTicks(9966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(7098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(6518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 578, DateTimeKind.Local).AddTicks(238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 577, DateTimeKind.Local).AddTicks(9851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 532, DateTimeKind.Local).AddTicks(9140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 926, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 528, DateTimeKind.Local).AddTicks(7807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 921, DateTimeKind.Local).AddTicks(6886));
        }
    }
}
