﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetcore_learning.model;

namespace dotnetcore_learning.Migrations
{
    [DbContext(typeof(PaymentContext))]
    [Migration("20190322153928_bittu")]
    partial class bittu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dotnetcore_learning.model.PaymentDetail", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("cardOwner")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("cvv")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<string>("expiryDate")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("paymentId");

                    b.ToTable("PaymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}