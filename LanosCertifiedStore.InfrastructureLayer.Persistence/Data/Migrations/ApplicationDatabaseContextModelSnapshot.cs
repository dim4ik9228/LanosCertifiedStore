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

            modelBuilder.Entity("Persistence.DataModels.IdentityRelated.RefreshTokenDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("RevocationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Persistence.DataModels.UserRelated.UserDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("character varying(320)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Persistence.DataModels.UserRelated.UserRoleDataModel", b =>
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

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a7a7967-8c35-4249-a5dd-47eefbbeb4eb"),
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("dd9208aa-b6d3-47b3-bb7e-a7aa0f07ea54"),
                            Name = "Administrator"
                        });
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationAreaDataModel", b =>
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

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleLocationAreas");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationRegionDataModel", b =>
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

                    b.ToTable("VehicleLocationRegions");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationTownDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationAreaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationRegionId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("LocationAreaId");

                    b.HasIndex("LocationRegionId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleLocationTowns");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleBodyTypeDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleBodyTypes");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleDrivetrainTypeDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleDrivetrainTypes");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleEngineTypeDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleEngineTypes");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTransmissionTypeDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleTransmissionTypes");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTypeDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleBrandDataModel", b =>
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

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleColorDataModel", b =>
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

                    b.ToTable("VehiclesColors");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleDataModel", b =>
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

                    b.Property<Guid?>("UserDataModelId")
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

                    b.HasIndex("UserDataModelId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleImageDataModel", b =>
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

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", b =>
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

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("VehicleBrandId");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehiclePriceDataModel", b =>
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

            modelBuilder.Entity("UserDataModelUserRoleDataModel", b =>
                {
                    b.Property<Guid>("RolesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uuid");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("UsersRoles", (string)null);
                });

            modelBuilder.Entity("VehicleBodyTypeDataModelVehicleModelDataModel", b =>
                {
                    b.Property<Guid>("AvailableBodyTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableBodyTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleBodyTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("VehicleDrivetrainTypeDataModelVehicleModelDataModel", b =>
                {
                    b.Property<Guid>("AvailableDrivetrainTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableDrivetrainTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleDrivetrainTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("VehicleEngineTypeDataModelVehicleModelDataModel", b =>
                {
                    b.Property<Guid>("AvailableEngineTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableEngineTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleEngineTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("VehicleModelDataModelVehicleTransmissionTypeDataModel", b =>
                {
                    b.Property<Guid>("AvailableTransmissionTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableTransmissionTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleTransmissionTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("VehicleModelDataModelVehicleTypeDataModel", b =>
                {
                    b.Property<Guid>("AvailableTypesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelsId")
                        .HasColumnType("uuid");

                    b.HasKey("AvailableTypesId", "ModelsId");

                    b.HasIndex("ModelsId");

                    b.ToTable("VehicleTypesVehicleModels", (string)null);
                });

            modelBuilder.Entity("Persistence.DataModels.IdentityRelated.RefreshTokenDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.UserRelated.UserDataModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationAreaDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationRegionDataModel", "LocationRegion")
                        .WithMany("RelatedAreas")
                        .HasForeignKey("LocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationRegion");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationTownDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationAreaDataModel", "LocationArea")
                        .WithMany("RelatedTowns")
                        .HasForeignKey("LocationAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationRegionDataModel", "LocationRegion")
                        .WithMany("RelatedTowns")
                        .HasForeignKey("LocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationArea");

                    b.Navigation("LocationRegion");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleBodyTypeDataModel", "BodyType")
                        .WithMany("Vehicles")
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleBrandDataModel", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleColorDataModel", "Color")
                        .WithMany("Vehicles")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleDrivetrainTypeDataModel", "DrivetrainType")
                        .WithMany("Vehicles")
                        .HasForeignKey("DrivetrainTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleEngineTypeDataModel", "EngineType")
                        .WithMany("Vehicles")
                        .HasForeignKey("EngineTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationAreaDataModel", "LocationArea")
                        .WithMany()
                        .HasForeignKey("LocationAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationRegionDataModel", "LocationRegion")
                        .WithMany()
                        .HasForeignKey("LocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationTownDataModel", "LocationTown")
                        .WithMany()
                        .HasForeignKey("LocationTownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", "Model")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTransmissionTypeDataModel", "TransmissionType")
                        .WithMany("Vehicles")
                        .HasForeignKey("TransmissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.UserRelated.UserDataModel", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("UserDataModelId");

                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTypeDataModel", "VehicleType")
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

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleImageDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleDataModel", "Vehicle")
                        .WithMany("Images")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleBrandDataModel", "VehicleBrand")
                        .WithMany("Models")
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("VehicleBrand");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehiclePriceDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleDataModel", "Vehicle")
                        .WithMany("Prices")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("UserDataModelUserRoleDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.UserRelated.UserRoleDataModel", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.UserRelated.UserDataModel", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleBodyTypeDataModelVehicleModelDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleBodyTypeDataModel", null)
                        .WithMany()
                        .HasForeignKey("AvailableBodyTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleDrivetrainTypeDataModelVehicleModelDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleDrivetrainTypeDataModel", null)
                        .WithMany()
                        .HasForeignKey("AvailableDrivetrainTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleEngineTypeDataModelVehicleModelDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleEngineTypeDataModel", null)
                        .WithMany()
                        .HasForeignKey("AvailableEngineTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleModelDataModelVehicleTransmissionTypeDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTransmissionTypeDataModel", null)
                        .WithMany()
                        .HasForeignKey("AvailableTransmissionTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleModelDataModelVehicleTypeDataModel", b =>
                {
                    b.HasOne("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTypeDataModel", null)
                        .WithMany()
                        .HasForeignKey("AvailableTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", null)
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Persistence.DataModels.UserRelated.UserDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationAreaDataModel", b =>
                {
                    b.Navigation("RelatedTowns");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.LocationRelated.VehicleLocationRegionDataModel", b =>
                {
                    b.Navigation("RelatedAreas");

                    b.Navigation("RelatedTowns");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleBodyTypeDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleDrivetrainTypeDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleEngineTypeDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTransmissionTypeDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.TypeRelated.VehicleTypeDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleBrandDataModel", b =>
                {
                    b.Navigation("Models");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleColorDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleDataModel", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("Persistence.DataModels.VehicleRelated.VehicleModelDataModel", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
