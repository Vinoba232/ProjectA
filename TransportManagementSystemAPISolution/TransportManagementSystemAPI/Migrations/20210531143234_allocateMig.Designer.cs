﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportManagementSystemAPI.Models;

namespace TransportManagementSystemAPI.Migrations
{
    [DbContext(typeof(TransportContext))]
    [Migration("20210531143234_allocateMig")]
    partial class allocateMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TransportManagementSystemAPI.Models.Allocation", b =>
                {
                    b.Property<int>("AllocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteNumber")
                        .HasColumnType("int");

                    b.Property<string>("VehicalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AllocationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RouteNumber");

                    b.ToTable("Allocations");
                });

            modelBuilder.Entity("TransportManagementSystemAPI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TransportManagementSystemAPI.Models.Login", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("TransportManagementSystemAPI.Models.Route", b =>
                {
                    b.Property<int>("RouteNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Stop1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stop2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stop3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RouteNumber");

                    b.HasIndex("VehicleNumber");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("TransportManagementSystemAPI.Models.Vehicle", b =>
                {
                    b.Property<string>("VehicleNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsAC")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOperational")
                        .HasColumnType("bit");

                    b.HasKey("VehicleNumber");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("TransportManagementSystemAPI.Models.Allocation", b =>
                {
                    b.HasOne("TransportManagementSystemAPI.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportManagementSystemAPI.Models.Route", "routes")
                        .WithMany()
                        .HasForeignKey("RouteNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("routes");
                });

            modelBuilder.Entity("TransportManagementSystemAPI.Models.Route", b =>
                {
                    b.HasOne("TransportManagementSystemAPI.Models.Vehicle", "Vehicles")
                        .WithMany()
                        .HasForeignKey("VehicleNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
