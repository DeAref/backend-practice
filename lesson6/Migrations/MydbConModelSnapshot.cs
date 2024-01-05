﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lesson5.Models;

#nullable disable

namespace lesson5.Migrations
{
    [DbContext(typeof(MydbCon))]
    partial class MydbConModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lesson5.Models.plans", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("planLimit")
                        .HasColumnType("int");

                    b.Property<string>("planName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("planPrice")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("plans");
                });

            modelBuilder.Entity("lesson5.Models.posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("documentPrice")
                        .HasColumnType("int");

                    b.Property<int>("off")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("posts");
                });
#pragma warning restore 612, 618
        }
    }
}
