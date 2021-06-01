using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Models.Migrations
{
    public partial class updateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(5011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publishDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.AddColumn<DateTime>(
                name: "accountinDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(8352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(7986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(5310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(7476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(6985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(7130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(6809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.AddColumn<DateTime>(
                name: "dateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "identityNumber",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "identityPlace",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "idetityDate",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(6274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(5885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 195, DateTimeKind.Local).AddTicks(7612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 926, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 191, DateTimeKind.Local).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 921, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.InsertData(
                table: "CustomerType",
                columns: new[] { "code", "CreateByusername", "UpdateByusername", "name", "note" },
                values: new object[] { "1", null, null, "Doanh nghiệp", null });

            migrationBuilder.InsertData(
                table: "CustomerType",
                columns: new[] { "code", "CreateByusername", "UpdateByusername", "name", "note" },
                values: new object[] { "0", null, null, "Cá nhân", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerType",
                keyColumn: "code",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "CustomerType",
                keyColumn: "code",
                keyValue: "1");

            migrationBuilder.DropColumn(
                name: "accountinDate",
                table: "InvoiceHeader");

            migrationBuilder.DropColumn(
                name: "dateOfBirth",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "identityNumber",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "identityPlace",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "idetityDate",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 3, DateTimeKind.Local).AddTicks(7686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 2, DateTimeKind.Local).AddTicks(4953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(3257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 44, 0, DateTimeKind.Local).AddTicks(2862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 998, DateTimeKind.Local).AddTicks(2455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 996, DateTimeKind.Local).AddTicks(8953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publishDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 995, DateTimeKind.Local).AddTicks(5551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(2182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 994, DateTimeKind.Local).AddTicks(1767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(9206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 992, DateTimeKind.Local).AddTicks(8793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 970, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 936, DateTimeKind.Local).AddTicks(6276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 928, DateTimeKind.Local).AddTicks(8572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 926, DateTimeKind.Local).AddTicks(3212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 195, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 30, 23, 43, 43, 921, DateTimeKind.Local).AddTicks(6886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 191, DateTimeKind.Local).AddTicks(3769));
        }
    }
}
