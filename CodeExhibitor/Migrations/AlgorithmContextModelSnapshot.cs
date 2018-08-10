﻿// <auto-generated />
using CodeExhibitor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeExhibitor.Migrations
{
    [DbContext(typeof(AlgorithmContext))]
    partial class AlgorithmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeExhibitor.Models.Algorithm", b =>
                {
                    b.Property<int>("AlgorithmId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BigONotation");

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("Objective");

                    b.HasKey("AlgorithmId");

                    b.ToTable("Algorithms");
                });

            modelBuilder.Entity("CodeExhibitor.Models.InterviewQuestion", b =>
                {
                    b.Property<int>("InterviewQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("Objective");

                    b.Property<string>("Solution");

                    b.HasKey("InterviewQuestionId");

                    b.ToTable("InterviewQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}