﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoContext))]
    partial class DoctorWhoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    b.Property<string>("AuthorName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("AuthorId")
                        .HasName("PK__tblAutho__70DAFC14745C864A");

                    b.ToTable("tblAuthor", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .HasColumnType("int")
                        .HasColumnName("CompanionID");

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("WhoPlayed")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("CompanionId")
                        .HasName("PK__tblCompa__8B53BE8B2BED7BDE");

                    b.ToTable("tblCompanion", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("DoctorID");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("DoctorName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FirstEpisodeDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("LastEpisodeDate")
                        .HasColumnType("date");

                    b.HasKey("DoctorId")
                        .HasName("PK__tblDocto__2DC00EDF6E1BB984");

                    b.ToTable("tblDoctor", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .HasColumnType("int")
                        .HasColumnName("EnemyID");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("EnemyId")
                        .HasName("PK__tblEnemy__911A0BD2AC4B36E9");

                    b.ToTable("tblEnemy", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodeID");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("DoctorID");

                    b.Property<DateOnly>("EpisodeDate")
                        .HasColumnType("date");

                    b.Property<short>("EpisodeNumber")
                        .HasColumnType("smallint");

                    b.Property<string>("EpisodeType")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Notes")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.HasKey("EpisodeId")
                        .HasName("PK__tblEpiso__AC66761511820723");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("tblEpisode", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodeCompanionID");

                    b.Property<int?>("CompanionId")
                        .HasColumnType("int")
                        .HasColumnName("CompanionID");

                    b.Property<int?>("EpisodeId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodeID");

                    b.HasKey("EpisodeCompanionId")
                        .HasName("PK__tblEpiso__774F3833F16FC7C1");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("tblEpisodeCompanion", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodeEnemyID");

                    b.Property<int?>("EnemyId")
                        .HasColumnType("int")
                        .HasColumnName("EnemyID");

                    b.Property<int?>("EpisodeId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodeID");

                    b.HasKey("EpisodeEnemyId")
                        .HasName("PK__tblEpiso__6DF24E50BD88F397");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("tblEpisodeEnemy", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.ViewEpisode", b =>
                {
                    b.Property<int?>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    b.Property<string>("AuthorName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Companions")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("DoctorID");

                    b.Property<string>("DoctorName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Enemies")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateOnly>("EpisodeDate")
                        .HasColumnType("date");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodeID");

                    b.Property<short>("EpisodeNumber")
                        .HasColumnType("smallint");

                    b.Property<string>("EpisodeType")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Notes")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.ToTable((string)null);

                    b.ToView("viewEpisodes", (string)null);
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", "Author")
                        .WithMany("TblEpisodes")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK__tblEpisod__Autho__2B3F6F97");

                    b.HasOne("DoctorWho.Db.Doctor", "Doctor")
                        .WithMany("TblEpisodes")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__tblEpisod__Docto__2C3393D0");

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "Companion")
                        .WithMany("TblEpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .HasConstraintName("FK__tblEpisod__Compa__398D8EEE");

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("TblEpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .HasConstraintName("FK__tblEpisod__Episo__38996AB5");

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", "Enemy")
                        .WithMany("TblEpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .HasConstraintName("FK__tblEpisod__Enemy__3D5E1FD2");

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("TblEpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .HasConstraintName("FK__tblEpisod__Episo__3C69FB99");

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("TblEpisodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Navigation("TblEpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("TblEpisodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Navigation("TblEpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Navigation("TblEpisodeCompanions");

                    b.Navigation("TblEpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}