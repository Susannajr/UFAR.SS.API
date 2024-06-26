﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UFAR_SS_Data.DAO;

#nullable disable

namespace UFAR_SS_Data.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UFAR_SS_Data.Entities.AuthorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("UFAR_SS_Data.Entities.ItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AuthorEntityId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("UFAR_SS_Data.Entities.StyleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ItemEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ItemEntityId");

                    b.ToTable("Styles");
                });

            modelBuilder.Entity("UFAR_SS_Data.Entities.ItemEntity", b =>
                {
                    b.HasOne("UFAR_SS_Data.Entities.AuthorEntity", null)
                        .WithMany("Items")
                        .HasForeignKey("AuthorEntityId");
                });

            modelBuilder.Entity("UFAR_SS_Data.Entities.StyleEntity", b =>
                {
                    b.HasOne("UFAR_SS_Data.Entities.ItemEntity", null)
                        .WithMany("Styles")
                        .HasForeignKey("ItemEntityId");
                });

            modelBuilder.Entity("UFAR_SS_Data.Entities.AuthorEntity", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("UFAR_SS_Data.Entities.ItemEntity", b =>
                {
                    b.Navigation("Styles");
                });
#pragma warning restore 612, 618
        }
    }
}
