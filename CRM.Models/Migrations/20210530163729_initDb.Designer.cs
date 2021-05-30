﻿// <auto-generated />
using System;
using CRM.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM.Models.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210530163729_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRM.Models.Company", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 528, DateTimeKind.Local).AddTicks(7807));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 532, DateTimeKind.Local).AddTicks(9140));

                    b.Property<string>("address")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("contactPerson")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("contactPosition")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("displayAddress")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("displayFaxNumber")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("displayPhone")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("displayTaxCode")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("displyEmail")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("email")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("faxNumber")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("representPerson")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("representPosition")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("taxCode")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("CRM.Models.Currency", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3360));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 535, DateTimeKind.Local).AddTicks(3783));

                    b.Property<bool>("getExchange")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("CRM.Models.Customer", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(566));

                    b.Property<string>("RepresentPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 541, DateTimeKind.Local).AddTicks(908));

                    b.Property<string>("address")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("bankAccountName")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("bankName")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("bankNumber")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("contactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerTypecode")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taxCode")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.HasIndex("customerTypecode");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CRM.Models.CustomerType", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 577, DateTimeKind.Local).AddTicks(9851));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 578, DateTimeKind.Local).AddTicks(238));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("CustomerType");
                });

            modelBuilder.Entity("CRM.Models.InvoiceDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(6518));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 600, DateTimeKind.Local).AddTicks(7098));

                    b.Property<string>("functioncode")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("headercode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("itemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("unitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("unitcode")
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("id");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.HasIndex("functioncode");

                    b.HasIndex("headercode");

                    b.HasIndex("unitcode");

                    b.ToTable("InvoiceDetail");
                });

            modelBuilder.Entity("CRM.Models.InvoiceDetailFunction", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 601, DateTimeKind.Local).AddTicks(9966));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 602, DateTimeKind.Local).AddTicks(318));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("InvoiceDetailFunction");
                });

            modelBuilder.Entity("CRM.Models.InvoiceHeader", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(2978));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 603, DateTimeKind.Local).AddTicks(3323));

                    b.Property<string>("currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currencyInText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerBankAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerBankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerTaxCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("exChangeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("invoiceNo")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("invoiceTypecode")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("patern")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("paymentMethodcode")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("publishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("sellerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sellerBankAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sellerBankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sellerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sellerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sellerTaxCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("totalDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("totalNoTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("totalTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("totalWithTax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.HasIndex("invoiceTypecode");

                    b.HasIndex("paymentMethodcode");

                    b.ToTable("InvoiceHeader");
                });

            modelBuilder.Entity("CRM.Models.InvoiceType", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(5801));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 604, DateTimeKind.Local).AddTicks(6142));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("InvoiceType");
                });

            modelBuilder.Entity("CRM.Models.PaymentMethod", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(8787));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 605, DateTimeKind.Local).AddTicks(9186));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("CRM.Models.PaymentStatus", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8215));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 607, DateTimeKind.Local).AddTicks(8629));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("PaymentStatus");
                });

            modelBuilder.Entity("CRM.Models.TaxType", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8589));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 609, DateTimeKind.Local).AddTicks(8921));

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("percent")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("TaxType");
                });

            modelBuilder.Entity("CRM.Models.Unit", b =>
                {
                    b.Property<string>("code")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CreateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 610, DateTimeKind.Local).AddTicks(9958));

                    b.Property<string>("UpdateByusername")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 30, 23, 37, 28, 611, DateTimeKind.Local).AddTicks(303));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("code");

                    b.HasIndex("CreateByusername");

                    b.HasIndex("UpdateByusername");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("CRM.Models.User", b =>
                {
                    b.Property<string>("username")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hashKey")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("username");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CRM.Models.Company", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.Currency", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.Customer", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.HasOne("CRM.Models.CustomerType", "customerType")
                        .WithMany()
                        .HasForeignKey("customerTypecode");

                    b.Navigation("CreateBy");

                    b.Navigation("customerType");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.CustomerType", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.InvoiceDetail", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.HasOne("CRM.Models.InvoiceDetailFunction", "function")
                        .WithMany()
                        .HasForeignKey("functioncode");

                    b.HasOne("CRM.Models.InvoiceHeader", "header")
                        .WithMany()
                        .HasForeignKey("headercode");

                    b.HasOne("CRM.Models.Unit", "unit")
                        .WithMany()
                        .HasForeignKey("unitcode");

                    b.Navigation("CreateBy");

                    b.Navigation("function");

                    b.Navigation("header");

                    b.Navigation("unit");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.InvoiceDetailFunction", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.InvoiceHeader", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.HasOne("CRM.Models.InvoiceType", "invoiceType")
                        .WithMany()
                        .HasForeignKey("invoiceTypecode");

                    b.HasOne("CRM.Models.PaymentMethod", "paymentMethod")
                        .WithMany()
                        .HasForeignKey("paymentMethodcode");

                    b.Navigation("CreateBy");

                    b.Navigation("invoiceType");

                    b.Navigation("paymentMethod");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.InvoiceType", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.PaymentMethod", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.PaymentStatus", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.TaxType", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("CRM.Models.Unit", b =>
                {
                    b.HasOne("CRM.Models.User", "CreateBy")
                        .WithMany()
                        .HasForeignKey("CreateByusername");

                    b.HasOne("CRM.Models.User", "UpdateBy")
                        .WithMany()
                        .HasForeignKey("UpdateByusername");

                    b.Navigation("CreateBy");

                    b.Navigation("UpdateBy");
                });
#pragma warning restore 612, 618
        }
    }
}