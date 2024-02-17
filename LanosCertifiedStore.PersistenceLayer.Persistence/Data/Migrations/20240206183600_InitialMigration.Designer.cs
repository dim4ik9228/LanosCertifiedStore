﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;
using Persistence.Contexts.ApplicationDatabaseContext;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    [Migration("20240206183600_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<Guid>("DisplacementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.HasIndex("DisplacementId");

                    b.HasIndex("ModelId");

                    b.HasIndex("TypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleBrand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("VehiclesBrands");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleColor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("VehiclesColors");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleDisplacement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("VehicleDisplacements");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehiclePrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<Guid>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehiclePrices");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.Vehicle", b =>
                {
                    b.HasOne("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleBrand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleColor", "Color")
                        .WithMany("Vehicles")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleDisplacement", "Displacement")
                        .WithMany("Vehicles")
                        .HasForeignKey("DisplacementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleModel", "Model")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleType", "Type")
                        .WithMany("Vehicles")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Color");

                    b.Navigation("Displacement");

                    b.Navigation("Model");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehiclePrice", b =>
                {
                    b.HasOne("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.Vehicle", "Vehicle")
                        .WithMany("Price")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.Vehicle", b =>
                {
                    b.Navigation("Price");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleBrand", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleColor", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleDisplacement", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("LanosCertifiedStore.DomainLayer.Domain.Entities.VehicleRelated.Classes.VehicleType", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
