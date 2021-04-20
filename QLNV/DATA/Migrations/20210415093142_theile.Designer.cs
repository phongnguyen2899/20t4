﻿// <auto-generated />
using System;
using DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DATA.Migrations
{
    [DbContext(typeof(dbcontext))]
    [Migration("20210415093142_theile")]
    partial class theile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATA.Entity.Chucvu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tenchucvu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Chucvus");
                });

            modelBuilder.Entity("DATA.Entity.Nhanvien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChucvuId")
                        .HasColumnType("int");

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngaysinhh")
                        .HasColumnType("datetime2");

                    b.Property<int>("Nguoigioithieu")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VitriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChucvuId");

                    b.HasIndex("VitriId");

                    b.ToTable("Nhanviens");
                });

            modelBuilder.Entity("DATA.Entity.Vitri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tenvitri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vitris");
                });

            modelBuilder.Entity("DATA.Entity.Nhanvien", b =>
                {
                    b.HasOne("DATA.Entity.Chucvu", "Chucvu")
                        .WithMany("Nhanviens")
                        .HasForeignKey("ChucvuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Entity.Vitri", "Vitri")
                        .WithMany("Nhanviens")
                        .HasForeignKey("VitriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
