﻿// <auto-generated />
using FitnessTreker_v1._0._2_OLYU.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessTreker_v1._0._2_OLYU.Migrations
{
    [DbContext(typeof(Gym))]
    [Migration("20240219190424_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitnessTreker_v1._0._2_OLYU.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerId"), 1L, 1);

                    b.Property<string>("TrainerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("FitnessTreker_v1._0._2_OLYU.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTelegramId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitnessTreker_v1._0._2_OLYU.Models.WorkoutSchedule", b =>
                {
                    b.Property<int>("WorkoutScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkoutScheduleId"), 1L, 1);

                    b.Property<string>("EndWHString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartWHString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.Property<string>("WorkoutDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkoutName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutTypeId")
                        .HasColumnType("int");

                    b.HasKey("WorkoutScheduleId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("WorkoutTypeId");

                    b.ToTable("WorkoutSchedules");
                });

            modelBuilder.Entity("FitnessTreker_v1._0._2_OLYU.Models.WorkoutTypes", b =>
                {
                    b.Property<int>("WorkoutTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkoutTypeId"), 1L, 1);

                    b.Property<string>("WorkoutName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkoutTypeId");

                    b.ToTable("WorkoutTypes");
                });

            modelBuilder.Entity("FitnessTreker_v1._0._2_OLYU.Models.WorkoutSchedule", b =>
                {
                    b.HasOne("FitnessTreker_v1._0._2_OLYU.Models.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessTreker_v1._0._2_OLYU.Models.WorkoutTypes", "WorkoutType")
                        .WithMany("WorkoutSchedules")
                        .HasForeignKey("WorkoutTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");

                    b.Navigation("WorkoutType");
                });

            modelBuilder.Entity("FitnessTreker_v1._0._2_OLYU.Models.WorkoutTypes", b =>
                {
                    b.Navigation("WorkoutSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
