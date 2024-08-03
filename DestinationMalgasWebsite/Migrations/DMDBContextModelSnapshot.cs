﻿// <auto-generated />
using System;
using DestinationMalgasWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DestinationMalgasWebsite.Migrations
{
    [DbContext(typeof(DMDBContext))]
    partial class DMDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.Amenity", b =>
                {
                    b.Property<int>("AmenityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmenityID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AmenityID");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int>("Adults")
                        .HasColumnType("int");

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPending")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuccessful")
                        .HasColumnType("bit");

                    b.Property<int>("Kids")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BookingID");

                    b.HasIndex("PropertyID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Bathrooms")
                        .HasColumnType("int");

                    b.Property<string>("HouseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Sleeps")
                        .HasColumnType("int");

                    b.HasKey("PropertyID");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.PropertyAmenity", b =>
                {
                    b.Property<int>("PropertyID")
                        .HasColumnType("int");

                    b.Property<int>("AmenityID")
                        .HasColumnType("int");

                    b.HasKey("PropertyID", "AmenityID");

                    b.HasIndex("AmenityID");

                    b.ToTable("PropertyAmenities");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.PropertyPhoto", b =>
                {
                    b.Property<int>("PhotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhotoID"));

                    b.Property<string>("PhotoString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyID")
                        .HasColumnType("int");

                    b.HasKey("PhotoID");

                    b.HasIndex("PropertyID");

                    b.ToTable("PropertyPhotos");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.Booking", b =>
                {
                    b.HasOne("DestinationMalgasWebsite.DBModels.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.PropertyAmenity", b =>
                {
                    b.HasOne("DestinationMalgasWebsite.DBModels.Amenity", "Amenity")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("AmenityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DestinationMalgasWebsite.DBModels.Property", "Property")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.PropertyPhoto", b =>
                {
                    b.HasOne("DestinationMalgasWebsite.DBModels.Property", "Property")
                        .WithMany("PropertyPhotos")
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.Amenity", b =>
                {
                    b.Navigation("PropertyAmenities");
                });

            modelBuilder.Entity("DestinationMalgasWebsite.DBModels.Property", b =>
                {
                    b.Navigation("PropertyAmenities");

                    b.Navigation("PropertyPhotos");
                });
#pragma warning restore 612, 618
        }
    }
}
