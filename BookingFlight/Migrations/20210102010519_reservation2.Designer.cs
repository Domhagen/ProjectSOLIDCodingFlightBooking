﻿// <auto-generated />
using BookingFlight.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingFlight.Migrations
{
    [DbContext(typeof(FlightContext))]
    [Migration("20210102010519_reservation2")]
    partial class reservation2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingFlight.Models.FlightTicket", b =>
                {
                    b.Property<int>("FlightTicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FlightDestination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("int");

                    b.HasKey("FlightTicketID");

                    b.ToTable("FlightTickets");
                });

            modelBuilder.Entity("BookingFlight.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("FlightTicketID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("FlightTicketID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("BookingFlight.Models.Reservation", b =>
                {
                    b.HasOne("BookingFlight.Models.FlightTicket", "FlightTicket")
                        .WithMany("Reservations")
                        .HasForeignKey("FlightTicketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
