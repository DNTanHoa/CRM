using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Models.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    password = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hashKey = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    taxCode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    displayTaxCode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    displayPhone = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    email = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    displyEmail = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    faxNumber = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    displayFaxNumber = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    representPerson = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    representPosition = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    contactPerson = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    contactPosition = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    displayAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 528, DateTimeKind.Local).AddTicks(7807)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 532, DateTimeKind.Local).AddTicks(9140))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.code);
                    table.ForeignKey(
                        name: "FK_Company_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    getExchange = table.Column<bool>(type: "bit", nullable: false),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3360)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3783))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.code);
                    table.ForeignKey(
                        name: "FK_Currency_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Currency_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 577, DateTimeKind.Local).AddTicks(9851)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 578, DateTimeKind.Local).AddTicks(238))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.code);
                    table.ForeignKey(
                        name: "FK_CustomerType_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerType_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetailFunction",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 601, DateTimeKind.Local).AddTicks(9966)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 602, DateTimeKind.Local).AddTicks(318))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetailFunction", x => x.code);
                    table.ForeignKey(
                        name: "FK_InvoiceDetailFunction_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetailFunction_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceType",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(5801)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(6142))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceType", x => x.code);
                    table.ForeignKey(
                        name: "FK_InvoiceType_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceType_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(8787)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(9186))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.code);
                    table.ForeignKey(
                        name: "FK_PaymentMethod_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentMethod_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8215)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8629))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.code);
                    table.ForeignKey(
                        name: "FK_PaymentStatus_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentStatus_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaxType",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    percent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8589)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8921))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxType", x => x.code);
                    table.ForeignKey(
                        name: "FK_TaxType_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaxType_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 610, DateTimeKind.Local).AddTicks(9958)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 611, DateTimeKind.Local).AddTicks(303))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.code);
                    table.ForeignKey(
                        name: "FK_Unit_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Unit_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    taxCode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    bankAccountName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    bankNumber = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    bankName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepresentPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerTypecode = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(566)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(908))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.code);
                    table.ForeignKey(
                        name: "FK_Customer_CustomerType_customerTypecode",
                        column: x => x.customerTypecode,
                        principalTable: "CustomerType",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceHeader",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    invoiceNo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    patern = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    serial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerTaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerBankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerBankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sellerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sellerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sellerTaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sellerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sellerBankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sellerBankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentMethodcode = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    invoiceTypecode = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    totalNoTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalWithTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    exChangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currencyInText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    publishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(2978)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(3323))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceHeader", x => x.code);
                    table.ForeignKey(
                        name: "FK_InvoiceHeader_InvoiceType_invoiceTypecode",
                        column: x => x.invoiceTypecode,
                        principalTable: "InvoiceType",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceHeader_PaymentMethod_paymentMethodcode",
                        column: x => x.paymentMethodcode,
                        principalTable: "PaymentMethod",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceHeader_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceHeader_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    headercode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    itemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unitcode = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    functioncode = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(6518)),
                    UpdateByusername = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(7098))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_InvoiceDetail_InvoiceDetailFunction_functioncode",
                        column: x => x.functioncode,
                        principalTable: "InvoiceDetailFunction",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetail_InvoiceHeader_headercode",
                        column: x => x.headercode,
                        principalTable: "InvoiceHeader",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetail_Unit_unitcode",
                        column: x => x.unitcode,
                        principalTable: "Unit",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetail_User_CreateByusername",
                        column: x => x.CreateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetail_User_UpdateByusername",
                        column: x => x.UpdateByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_CreateByusername",
                table: "Company",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UpdateByusername",
                table: "Company",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_CreateByusername",
                table: "Currency",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_UpdateByusername",
                table: "Currency",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CreateByusername",
                table: "Customer",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_customerTypecode",
                table: "Customer",
                column: "customerTypecode");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UpdateByusername",
                table: "Customer",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerType_CreateByusername",
                table: "CustomerType",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerType_UpdateByusername",
                table: "CustomerType",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetail_CreateByusername",
                table: "InvoiceDetail",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetail_functioncode",
                table: "InvoiceDetail",
                column: "functioncode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetail_headercode",
                table: "InvoiceDetail",
                column: "headercode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetail_unitcode",
                table: "InvoiceDetail",
                column: "unitcode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetail_UpdateByusername",
                table: "InvoiceDetail",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetailFunction_CreateByusername",
                table: "InvoiceDetailFunction",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetailFunction_UpdateByusername",
                table: "InvoiceDetailFunction",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeader_CreateByusername",
                table: "InvoiceHeader",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeader_invoiceTypecode",
                table: "InvoiceHeader",
                column: "invoiceTypecode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeader_paymentMethodcode",
                table: "InvoiceHeader",
                column: "paymentMethodcode");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceHeader_UpdateByusername",
                table: "InvoiceHeader",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceType_CreateByusername",
                table: "InvoiceType",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceType_UpdateByusername",
                table: "InvoiceType",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_CreateByusername",
                table: "PaymentMethod",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_UpdateByusername",
                table: "PaymentMethod",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_CreateByusername",
                table: "PaymentStatus",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_UpdateByusername",
                table: "PaymentStatus",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_CreateByusername",
                table: "TaxType",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_UpdateByusername",
                table: "TaxType",
                column: "UpdateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_CreateByusername",
                table: "Unit",
                column: "CreateByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_UpdateByusername",
                table: "Unit",
                column: "UpdateByusername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "InvoiceDetail");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "TaxType");

            migrationBuilder.DropTable(
                name: "CustomerType");

            migrationBuilder.DropTable(
                name: "InvoiceDetailFunction");

            migrationBuilder.DropTable(
                name: "InvoiceHeader");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "InvoiceType");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
