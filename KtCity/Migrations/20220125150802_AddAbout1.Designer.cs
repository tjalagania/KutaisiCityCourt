﻿// <auto-generated />
using System;
using KtCity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KtCity.Migrations
{
    [DbContext(typeof(KcDbContext))]
    [Migration("20220125150802_AddAbout1")]
    partial class AddAbout1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KtCity.Models.About", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("About");
                });

            modelBuilder.Entity("KtCity.Models.AboutAtachFiles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anotation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AboutAtachFiles");
                });

            modelBuilder.Entity("KtCity.Models.AboutRekvizit", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Aboutid")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Aboutid");

                    b.ToTable("AboutRekvizites");
                });

            modelBuilder.Entity("KtCity.Models.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("KtCity.Models.AtachFiles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Commandsid")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Newsid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Commandsid");

                    b.HasIndex("Newsid");

                    b.ToTable("AtachFiles");
                });

            modelBuilder.Entity("KtCity.Models.Commands", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Commands");
                });

            modelBuilder.Entity("KtCity.Models.Galery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Galeries");
                });

            modelBuilder.Entity("KtCity.Models.GaleryImgs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Galeryid")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Galeryid");

                    b.ToTable("GaleryImages");
                });

            modelBuilder.Entity("KtCity.Models.Judge", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Chariman")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Palataid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Palataid");

                    b.ToTable("Judges");
                });

            modelBuilder.Entity("KtCity.Models.News", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("KtCity.Models.Palats", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rang")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Palats");
                });

            modelBuilder.Entity("KtCity.Models.Position", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rang")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("KtCity.Models.Worker", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Positionid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Positionid");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("KtCity.Models.AboutRekvizit", b =>
                {
                    b.HasOne("KtCity.Models.About", null)
                        .WithMany("Rekvizites")
                        .HasForeignKey("Aboutid");
                });

            modelBuilder.Entity("KtCity.Models.AtachFiles", b =>
                {
                    b.HasOne("KtCity.Models.Commands", null)
                        .WithMany("AttachFiles")
                        .HasForeignKey("Commandsid");

                    b.HasOne("KtCity.Models.News", null)
                        .WithMany("AttachFiles")
                        .HasForeignKey("Newsid");
                });

            modelBuilder.Entity("KtCity.Models.GaleryImgs", b =>
                {
                    b.HasOne("KtCity.Models.Galery", "Galery")
                        .WithMany("Images")
                        .HasForeignKey("Galeryid");

                    b.Navigation("Galery");
                });

            modelBuilder.Entity("KtCity.Models.Judge", b =>
                {
                    b.HasOne("KtCity.Models.Palats", "Palata")
                        .WithMany("Judges")
                        .HasForeignKey("Palataid");

                    b.Navigation("Palata");
                });

            modelBuilder.Entity("KtCity.Models.Worker", b =>
                {
                    b.HasOne("KtCity.Models.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("Positionid");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("KtCity.Models.About", b =>
                {
                    b.Navigation("Rekvizites");
                });

            modelBuilder.Entity("KtCity.Models.Commands", b =>
                {
                    b.Navigation("AttachFiles");
                });

            modelBuilder.Entity("KtCity.Models.Galery", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("KtCity.Models.News", b =>
                {
                    b.Navigation("AttachFiles");
                });

            modelBuilder.Entity("KtCity.Models.Palats", b =>
                {
                    b.Navigation("Judges");
                });

            modelBuilder.Entity("KtCity.Models.Position", b =>
                {
                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
