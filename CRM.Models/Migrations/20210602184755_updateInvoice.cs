using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Models.Migrations
{
    public partial class updateInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetail_InvoiceDetailFunction_functioncode",
                table: "InvoiceDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetail_InvoiceHeader_headercode",
                table: "InvoiceDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetail_Unit_unitcode",
                table: "InvoiceDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetail_User_CreateByusername",
                table: "InvoiceDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetail_User_UpdateByusername",
                table: "InvoiceDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeader_InvoiceType_invoiceTypecode",
                table: "InvoiceHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeader_PaymentMethod_paymentMethodcode",
                table: "InvoiceHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeader_User_CreateByusername",
                table: "InvoiceHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeader_User_UpdateByusername",
                table: "InvoiceHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceHeader",
                table: "InvoiceHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDetail",
                table: "InvoiceDetail");

            migrationBuilder.RenameTable(
                name: "InvoiceHeader",
                newName: "InvoiceHeaders");

            migrationBuilder.RenameTable(
                name: "InvoiceDetail",
                newName: "InvoiceDetails");

            migrationBuilder.RenameColumn(
                name: "accountinDate",
                table: "InvoiceHeaders",
                newName: "accountingDate");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeader_UpdateByusername",
                table: "InvoiceHeaders",
                newName: "IX_InvoiceHeaders_UpdateByusername");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeader_paymentMethodcode",
                table: "InvoiceHeaders",
                newName: "IX_InvoiceHeaders_paymentMethodcode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeader_invoiceTypecode",
                table: "InvoiceHeaders",
                newName: "IX_InvoiceHeaders_invoiceTypecode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeader_CreateByusername",
                table: "InvoiceHeaders",
                newName: "IX_InvoiceHeaders_CreateByusername");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetail_UpdateByusername",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_UpdateByusername");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetail_unitcode",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_unitcode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetail_headercode",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_headercode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetail_functioncode",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_functioncode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetail_CreateByusername",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_CreateByusername");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(2294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "InvoiceType",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(9405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(8942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 195, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 191, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeaders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AddColumn<string>(
                name: "accountingPersonusername",
                table: "InvoiceHeaders",
                type: "nvarchar(1000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "creditAccountcode",
                table: "InvoiceHeaders",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "debitAccountcode",
                table: "InvoiceHeaders",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "InvoiceHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "documentNumber",
                table: "InvoiceHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "eInvoicePublish",
                table: "InvoiceHeaders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "invoiceStatuscode",
                table: "InvoiceHeaders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "paymentTermcode",
                table: "InvoiceHeaders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(7084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(6639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceHeaders",
                table: "InvoiceHeaders",
                column: "code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDetails",
                table: "InvoiceDetails",
                column: "id");

            migrationBuilder.CreateTable(
                name: "AccountingPeriod",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    fiscalYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateLocked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isClosed = table.Column<bool>(type: "bit", nullable: false),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 277, DateTimeKind.Local).AddTicks(5175)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 281, DateTimeKind.Local).AddTicks(7113))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingPeriod", x => x.code);
                    table.ForeignKey(
                        name: "FK_AccountingPeriod_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountingPeriod_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GLAccount",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    netChange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    creditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    debitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    isCredit = table.Column<bool>(type: "bit", nullable: false),
                    isDebit = table.Column<bool>(type: "bit", nullable: false),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 328, DateTimeKind.Local).AddTicks(6228)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 328, DateTimeKind.Local).AddTicks(6551))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLAccount", x => x.code);
                    table.ForeignKey(
                        name: "FK_GLAccount_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GLAccount_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GLCategory",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 325, DateTimeKind.Local).AddTicks(9791)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 326, DateTimeKind.Local).AddTicks(139))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLCategory", x => x.code);
                    table.ForeignKey(
                        name: "FK_GLCategory_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GLCategory_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStatus",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    allowEdit = table.Column<bool>(type: "bit", nullable: false),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 335, DateTimeKind.Local).AddTicks(7455)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 335, DateTimeKind.Local).AddTicks(7781))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatus", x => x.code);
                    table.ForeignKey(
                        name: "FK_InvoiceStatus_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceStatus_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerm",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 342, DateTimeKind.Local).AddTicks(8291)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 342, DateTimeKind.Local).AddTicks(8626))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerm", x => x.code);
                    table.ForeignKey(
                        name: "FK_PaymentTerm_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentTerm_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeaders_accountingPersonusername",
                table: "InvoiceHeaders",
                column: "accountingPersonusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeaders_creditAccountcode",
                table: "InvoiceHeaders",
                column: "creditAccountcode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeaders_debitAccountcode",
                table: "InvoiceHeaders",
                column: "debitAccountcode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeaders_invoiceStatuscode",
                table: "InvoiceHeaders",
                column: "invoiceStatuscode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeaders_paymentTermcode",
                table: "InvoiceHeaders",
                column: "paymentTermcode");

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriod_CreateByusername",
                table: "AccountingPeriod",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriod_UpdateByusername",
                table: "AccountingPeriod",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_GLAccount_CreateByusername",
                table: "GLAccount",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_GLAccount_UpdateByusername",
                table: "GLAccount",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_GLCategory_CreateByusername",
                table: "GLCategory",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_GLCategory_UpdateByusername",
                table: "GLCategory",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceStatus_CreateByusername",
                table: "InvoiceStatus",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceStatus_UpdateByusername",
                table: "InvoiceStatus",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTerm_CreateByusername",
                table: "PaymentTerm",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTerm_UpdateByusername",
                table: "PaymentTerm",
                column: "UpdateByusername");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_InvoiceDetailFunction_functioncode",
                table: "InvoiceDetails",
                column: "functioncode",
                principalTable: "InvoiceDetailFunction",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_InvoiceHeaders_headercode",
                table: "InvoiceDetails",
                column: "headercode",
                principalTable: "InvoiceHeaders",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Unit_unitcode",
                table: "InvoiceDetails",
                column: "unitcode",
                principalTable: "Unit",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_User_CreateByusername",
                table: "InvoiceDetails",
                column: "CreateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_User_UpdateByusername",
                table: "InvoiceDetails",
                column: "UpdateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_GLAccount_creditAccountcode",
                table: "InvoiceHeaders",
                column: "creditAccountcode",
                principalTable: "GLAccount",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_GLAccount_debitAccountcode",
                table: "InvoiceHeaders",
                column: "debitAccountcode",
                principalTable: "GLAccount",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_InvoiceStatus_invoiceStatuscode",
                table: "InvoiceHeaders",
                column: "invoiceStatuscode",
                principalTable: "InvoiceStatus",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_InvoiceType_invoiceTypecode",
                table: "InvoiceHeaders",
                column: "invoiceTypecode",
                principalTable: "InvoiceType",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_PaymentMethod_paymentMethodcode",
                table: "InvoiceHeaders",
                column: "paymentMethodcode",
                principalTable: "PaymentMethod",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_PaymentTerm_paymentTermcode",
                table: "InvoiceHeaders",
                column: "paymentTermcode",
                principalTable: "PaymentTerm",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_User_accountingPersonusername",
                table: "InvoiceHeaders",
                column: "accountingPersonusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_User_CreateByusername",
                table: "InvoiceHeaders",
                column: "CreateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_User_UpdateByusername",
                table: "InvoiceHeaders",
                column: "UpdateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_InvoiceDetailFunction_functioncode",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_InvoiceHeaders_headercode",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Unit_unitcode",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_User_CreateByusername",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_User_UpdateByusername",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_GLAccount_creditAccountcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_GLAccount_debitAccountcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_InvoiceStatus_invoiceStatuscode",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_InvoiceType_invoiceTypecode",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_PaymentMethod_paymentMethodcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_PaymentTerm_paymentTermcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_User_accountingPersonusername",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_User_CreateByusername",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_User_UpdateByusername",
                table: "InvoiceHeaders");

            migrationBuilder.DropTable(
                name: "AccountingPeriod");

            migrationBuilder.DropTable(
                name: "GLAccount");

            migrationBuilder.DropTable(
                name: "GLCategory");

            migrationBuilder.DropTable(
                name: "InvoiceStatus");

            migrationBuilder.DropTable(
                name: "PaymentTerm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceHeaders",
                table: "InvoiceHeaders");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceHeaders_accountingPersonusername",
                table: "InvoiceHeaders");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceHeaders_creditAccountcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceHeaders_debitAccountcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceHeaders_invoiceStatuscode",
                table: "InvoiceHeaders");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceHeaders_paymentTermcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDetails",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "accountingPersonusername",
                table: "InvoiceHeaders");

            migrationBuilder.DropColumn(
                name: "creditAccountcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropColumn(
                name: "debitAccountcode",
                table: "InvoiceHeaders");

            migrationBuilder.DropColumn(
                name: "description",
                table: "InvoiceHeaders");

            migrationBuilder.DropColumn(
                name: "documentNumber",
                table: "InvoiceHeaders");

            migrationBuilder.DropColumn(
                name: "eInvoicePublish",
                table: "InvoiceHeaders");

            migrationBuilder.DropColumn(
                name: "invoiceStatuscode",
                table: "InvoiceHeaders");

            migrationBuilder.DropColumn(
                name: "paymentTermcode",
                table: "InvoiceHeaders");

            migrationBuilder.RenameTable(
                name: "InvoiceHeaders",
                newName: "InvoiceHeader");

            migrationBuilder.RenameTable(
                name: "InvoiceDetails",
                newName: "InvoiceDetail");

            migrationBuilder.RenameColumn(
                name: "accountingDate",
                table: "InvoiceHeader",
                newName: "accountinDate");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeaders_UpdateByusername",
                table: "InvoiceHeader",
                newName: "IX_InvoiceHeader_UpdateByusername");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeaders_paymentMethodcode",
                table: "InvoiceHeader",
                newName: "IX_InvoiceHeader_paymentMethodcode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeaders_invoiceTypecode",
                table: "InvoiceHeader",
                newName: "IX_InvoiceHeader_invoiceTypecode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeaders_CreateByusername",
                table: "InvoiceHeader",
                newName: "IX_InvoiceHeader_CreateByusername");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_UpdateByusername",
                table: "InvoiceDetail",
                newName: "IX_InvoiceDetail_UpdateByusername");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_unitcode",
                table: "InvoiceDetail",
                newName: "IX_InvoiceDetail_unitcode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_headercode",
                table: "InvoiceDetail",
                newName: "IX_InvoiceDetail_headercode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_functioncode",
                table: "InvoiceDetail",
                newName: "IX_InvoiceDetail_functioncode");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_CreateByusername",
                table: "InvoiceDetail",
                newName: "IX_InvoiceDetail_CreateByusername");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Unit",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 273, DateTimeKind.Local).AddTicks(7018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 346, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TaxType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 272, DateTimeKind.Local).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 345, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 270, DateTimeKind.Local).AddTicks(4658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 341, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(5011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentMethod",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 268, DateTimeKind.Local).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 339, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "InvoiceType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 267, DateTimeKind.Local).AddTicks(1138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 337, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(8352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetailFunction",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 263, DateTimeKind.Local).AddTicks(7986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 331, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(7476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 232, DateTimeKind.Local).AddTicks(6985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 323, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(7130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 199, DateTimeKind.Local).AddTicks(6809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 290, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(6274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Currency",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 198, DateTimeKind.Local).AddTicks(5885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 289, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 195, DateTimeKind.Local).AddTicks(7612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 191, DateTimeKind.Local).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 287, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 265, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 334, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(5310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "InvoiceDetail",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 6, 2, 0, 56, 31, 262, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 6, 3, 1, 47, 55, 330, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceHeader",
                table: "InvoiceHeader",
                column: "code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDetail",
                table: "InvoiceDetail",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetail_InvoiceDetailFunction_functioncode",
                table: "InvoiceDetail",
                column: "functioncode",
                principalTable: "InvoiceDetailFunction",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetail_InvoiceHeader_headercode",
                table: "InvoiceDetail",
                column: "headercode",
                principalTable: "InvoiceHeader",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetail_Unit_unitcode",
                table: "InvoiceDetail",
                column: "unitcode",
                principalTable: "Unit",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetail_User_CreateByusername",
                table: "InvoiceDetail",
                column: "CreateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetail_User_UpdateByusername",
                table: "InvoiceDetail",
                column: "UpdateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeader_InvoiceType_invoiceTypecode",
                table: "InvoiceHeader",
                column: "invoiceTypecode",
                principalTable: "InvoiceType",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeader_PaymentMethod_paymentMethodcode",
                table: "InvoiceHeader",
                column: "paymentMethodcode",
                principalTable: "PaymentMethod",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeader_User_CreateByusername",
                table: "InvoiceHeader",
                column: "CreateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeader_User_UpdateByusername",
                table: "InvoiceHeader",
                column: "UpdateByusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
