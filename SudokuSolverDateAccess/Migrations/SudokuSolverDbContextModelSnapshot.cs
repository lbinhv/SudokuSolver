﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SudokuSolver.DataAccess;

#nullable disable

namespace SudokuSolver.DataAccess.Migrations
{
    [DbContext(typeof(SudokuSolverDbContext))]
    partial class SudokuSolverDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SudokuSolver.Model.SolutionResultDM", b =>
                {
                    b.Property<Guid>("SolutionResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SolutionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SolutionStatus")
                        .HasColumnType("int");

                    b.HasKey("SolutionResultId");

                    b.ToTable("SolutionResults", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}