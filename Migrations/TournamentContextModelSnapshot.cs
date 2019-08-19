﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrizeTracker.Models;

namespace PrizeTracker.Migrations
{
    [DbContext(typeof(TournamentContext))]
    partial class TournamentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("PrizeTracker.Models.Tournament", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("NumberOfPlayers");

                    b.Property<int>("PrizePool");

                    b.Property<string>("RunnerUp");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TournamentName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Winner");

                    b.HasKey("ID");

                    b.ToTable("Tournament");
                });
#pragma warning restore 612, 618
        }
    }
}
