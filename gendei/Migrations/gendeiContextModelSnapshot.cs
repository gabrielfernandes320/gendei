﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using gendei.Entities;

namespace gendei.Migrations
{
    [DbContext(typeof(gendeiContext))]
    partial class gendeiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("gendei.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Complement")
                        .HasColumnType("text");

                    b.Property<bool>("IsMainAddress")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("text");

                    b.Property<int?>("Number")
                        .HasColumnType("integer");

                    b.Property<int?>("Postalcode")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("gendei.Entities.AttendantServiceRel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AttendantId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AttendantId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AttendantServiceRel");
                });

            modelBuilder.Entity("gendei.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("gendei.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsMainContact")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("gendei.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Iso")
                        .HasColumnType("text");

                    b.Property<string>("Iso3")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NiceName")
                        .HasColumnType("text");

                    b.Property<int?>("NumCode")
                        .HasColumnType("integer");

                    b.Property<int>("PhoneCode")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("gendei.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("gendei.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("AttendantId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Canceled")
                        .HasColumnType("boolean");

                    b.Property<string>("CanceledReason")
                        .HasColumnType("text");

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("interval");

                    b.Property<string>("Observation")
                        .HasColumnType("text");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("AttendantId");

                    b.HasIndex("ClientId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("gendei.Entities.ScheduleConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DayOfWeek")
                        .HasColumnType("integer");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<TimeSpan?>("EndTime")
                        .HasColumnType("interval");

                    b.Property<TimeSpan?>("StartTime")
                        .HasColumnType("interval");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ScheduleConfig");
                });

            modelBuilder.Entity("gendei.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("gendei.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AuthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastToken")
                        .HasColumnType("text");

                    b.Property<string>("RefreshTokenCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("TokenRefreshDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("gendei.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("gendei.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("gendei.Entities.Address", b =>
                {
                    b.HasOne("gendei.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gendei.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gendei.Entities.AttendantServiceRel", b =>
                {
                    b.HasOne("gendei.Entities.User", "Attendant")
                        .WithMany("AttendantServiceRel")
                        .HasForeignKey("AttendantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gendei.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gendei.Entities.City", b =>
                {
                    b.HasOne("gendei.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gendei.Entities.Contact", b =>
                {
                    b.HasOne("gendei.Entities.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("gendei.Entities.Schedule", b =>
                {
                    b.HasOne("gendei.Entities.User", "Attendant")
                        .WithMany("ScheduleAttendant")
                        .HasForeignKey("AttendantId")
                        .HasConstraintName("schedule_user_attendant_id_fk")
                        .IsRequired();

                    b.HasOne("gendei.Entities.User", "Client")
                        .WithMany("ScheduleClient")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("schedule_user_client_id_fk")
                        .IsRequired();
                });

            modelBuilder.Entity("gendei.Entities.ScheduleConfig", b =>
                {
                    b.HasOne("gendei.Entities.User", "User")
                        .WithMany("ScheduleConfig")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("gendei.Entities.Session", b =>
                {
                    b.HasOne("gendei.Entities.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gendei.Entities.State", b =>
                {
                    b.HasOne("gendei.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gendei.Entities.User", b =>
                {
                    b.HasOne("gendei.Entities.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
