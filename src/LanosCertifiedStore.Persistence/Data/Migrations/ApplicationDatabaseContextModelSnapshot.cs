﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Contexts.ApplicationDatabaseContext;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    partial class ApplicationDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationArea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationRegionId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("LocationRegionId");

                    b.HasIndex("Name");

                    b.ToTable("VehicleLocationAreas");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationRegion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("VehicleLocationRegions");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationTown", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationAreaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationRegionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationTownTypeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("LocationAreaId");

                    b.HasIndex("LocationRegionId");

                    b.HasIndex("LocationTownTypeId");

                    b.HasIndex("Name");

                    b.ToTable("VehicleLocationTowns");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationTownType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("VehicleLocationTownTypes");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleBodyType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleBodyTypes");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleDrivetrainType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleDrivetrainTypes");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleEngineType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleEngineTypes");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleTransmissionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleTransmissionTypes");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BodyTypeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<double>("Displacement")
                        .HasColumnType("double precision");

                    b.Property<Guid>("DrivetrainTypeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EngineTypeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationAreaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationRegionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationTownId")
                        .HasColumnType("uuid");

                    b.Property<int>("Mileage")
                        .HasColumnType("integer");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("uuid");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("integer");

                    b.Property<Guid>("TransmissionTypeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("VehicleTypeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.HasIndex("DrivetrainTypeId");

                    b.HasIndex("EngineTypeId");

                    b.HasIndex("LocationAreaId");

                    b.HasIndex("LocationRegionId");

                    b.HasIndex("LocationTownId");

                    b.HasIndex("ModelId");

                    b.HasIndex("TransmissionTypeId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleBrand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehiclesBrands");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleColor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("HexValue")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleColors");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CloudImageId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsMainImage")
                        .HasColumnType("boolean");

                    b.Property<Guid>("VehicleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleImages");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("MaximumProductionYear")
                        .HasColumnType("integer");

                    b.Property<int>("MinimalProductionYear")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<Guid>("VehicleBrandId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("VehicleTypeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("VehicleBrandId");

                    b.HasIndex("VehicleTypeId");

                    b.HasIndex("Name", "VehicleBrandId")
                        .IsUnique();

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehiclePrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("VehicleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehiclePrices");
                });

            modelBuilder.Entity("VehicleBodyTypeVehicleModel", b =>
                {
                    b.Property<Guid>("AvailableBodyTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableBodyTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleBodyTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("VehicleDrivetrainTypeVehicleModel", b =>
                {
                    b.Property<Guid>("AvailableDrivetrainTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableDrivetrainTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleDrivetrainTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("VehicleEngineTypeVehicleModel", b =>
                {
                    b.Property<Guid>("AvailableEngineTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableEngineTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleEngineTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("VehicleModelVehicleTransmissionType", b =>
                {
                    b.Property<Guid>("AvailableTransmissionTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableTransmissionTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleTransmissionTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationArea", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationRegion", "LocationRegion")
                        .WithMany("RelatedAreas")
                        .HasForeignKey("LocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationRegion");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationTown", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationArea", "LocationArea")
                        .WithMany("RelatedTowns")
                        .HasForeignKey("LocationAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationRegion", "LocationRegion")
                        .WithMany("RelatedTowns")
                        .HasForeignKey("LocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationTownType", "LocationTownType")
                        .WithMany("Towns")
                        .HasForeignKey("LocationTownTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationArea");

                    b.Navigation("LocationRegion");

                    b.Navigation("LocationTownType");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.Vehicle", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleBodyType", "BodyType")
                        .WithMany("Vehicles")
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.VehicleBrand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.VehicleColor", "Color")
                        .WithMany("Vehicles")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleDrivetrainType", "DrivetrainType")
                        .WithMany("Vehicles")
                        .HasForeignKey("DrivetrainTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleEngineType", "EngineType")
                        .WithMany("Vehicles")
                        .HasForeignKey("EngineTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationArea", "LocationArea")
                        .WithMany()
                        .HasForeignKey("LocationAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationRegion", "LocationRegion")
                        .WithMany()
                        .HasForeignKey("LocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationTown", "LocationTown")
                        .WithMany()
                        .HasForeignKey("LocationTownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.VehicleModel", "Model")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleTransmissionType", "TransmissionType")
                        .WithMany("Vehicles")
                        .HasForeignKey("TransmissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleType", "VehicleType")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyType");

                    b.Navigation("Brand");

                    b.Navigation("Color");

                    b.Navigation("DrivetrainType");

                    b.Navigation("EngineType");

                    b.Navigation("LocationArea");

                    b.Navigation("LocationRegion");

                    b.Navigation("LocationTown");

                    b.Navigation("Model");

                    b.Navigation("TransmissionType");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleImage", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.Vehicle", "Vehicle")
                        .WithMany("Images")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleModel", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.VehicleBrand", "VehicleBrand")
                        .WithMany("Models")
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleType", "VehicleType")
                        .WithMany("Models")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleBrand");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehiclePrice", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.Vehicle", "Vehicle")
                        .WithMany("Prices")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleBodyTypeVehicleModel", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleBodyType", null)
                        .WithMany()
                        .HasForeignKey("AvailableBodyTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.VehicleModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleDrivetrainTypeVehicleModel", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleDrivetrainType", null)
                        .WithMany()
                        .HasForeignKey("AvailableDrivetrainTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.VehicleModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleEngineTypeVehicleModel", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleEngineType", null)
                        .WithMany()
                        .HasForeignKey("AvailableEngineTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.VehicleModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleModelVehicleTransmissionType", b =>
                {
                    b.HasOne("Domain.Entities.VehicleRelated.TypeRelated.VehicleTransmissionType", null)
                        .WithMany()
                        .HasForeignKey("AvailableTransmissionTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.VehicleRelated.VehicleModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationArea", b =>
                {
                    b.Navigation("RelatedTowns");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationRegion", b =>
                {
                    b.Navigation("RelatedAreas");

                    b.Navigation("RelatedTowns");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.LocationRelated.VehicleLocationTownType", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleBodyType", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleDrivetrainType", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleEngineType", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleTransmissionType", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.TypeRelated.VehicleType", b =>
                {
                    b.Navigation("Models");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.Vehicle", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleBrand", b =>
                {
                    b.Navigation("Models");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleColor", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.VehicleRelated.VehicleModel", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
