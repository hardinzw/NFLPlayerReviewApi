﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NFLPlayerReview.Data;

#nullable disable

namespace NFLPlayerReview.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("NFLPlayerReview.Models.NFLDivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NFLDivisions");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PositionalRank")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("NFLPlayers");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NFLPositions");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DivisionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("NFLTeams");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.PlayerPosition", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PositionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId", "PositionId");

                    b.HasIndex("PositionId");

                    b.ToTable("PlayerPosititions");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.PlayerTeam", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("PlayerTeams");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.Reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Reviewers");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLTeam", b =>
                {
                    b.HasOne("NFLPlayerReview.Models.NFLDivision", "Division")
                        .WithMany("Teams")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.PlayerPosition", b =>
                {
                    b.HasOne("NFLPlayerReview.Models.NFLPlayer", "Player")
                        .WithMany("PlayerPositions")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NFLPlayerReview.Models.NFLPosition", "Position")
                        .WithMany("Positions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.PlayerTeam", b =>
                {
                    b.HasOne("NFLPlayerReview.Models.NFLPlayer", "Player")
                        .WithMany("PlayerTeams")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NFLPlayerReview.Models.NFLTeam", "Team")
                        .WithMany("Teams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.Review", b =>
                {
                    b.HasOne("NFLPlayerReview.Models.NFLPlayer", "Player")
                        .WithMany("Reviews")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NFLPlayerReview.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLDivision", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLPlayer", b =>
                {
                    b.Navigation("PlayerPositions");

                    b.Navigation("PlayerTeams");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLPosition", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.NFLTeam", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("NFLPlayerReview.Models.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}