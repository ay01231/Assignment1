﻿// <auto-generated />
using PaymentApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PaymentApi.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("Initial Migrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Final_Project_1.Models.Payment", b =>
            {
                b.Property<int>("PaymentDetailId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("CardNumber")
                    .HasColumnType("TEXT");

                b.Property<string>("CardOwnerName")
                    .HasColumnType("TEXT");

                b.Property<string>("ExpirationDate")
                    .HasColumnType("TEXT");

                b.Property<string>("SecurityCode")
                    .HasColumnType("TEXT");

                b.HasKey("PaymentDetailId");

                b.ToTable("Payments");
            });
#pragma warning restore 612, 618
        }
    }
}
