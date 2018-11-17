﻿// <auto-generated />
using System;
using Collaboo.App.WebAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Collaboo.App.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181117194246_CreateUserTable")]
    partial class CreateUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.Follower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Followers");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("GitHubRepoUrl");

                    b.Property<int>("OwnerId");

                    b.Property<string>("ProjectName");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.ProjectMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectMember");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.ProjectRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProjectId");

                    b.Property<int>("Rating");

                    b.Property<int>("SkillId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SkillId");

                    b.ToTable("ProjectRequirments");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SkillName");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GitHubId");

                    b.Property<string>("Login");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.UserFollowers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FollowerId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FollowerId");

                    b.ToTable("UserFollowers");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.UserSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Rating");

                    b.Property<int>("SkillId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.ProjectMember", b =>
                {
                    b.HasOne("Collaboo.App.WebAPI.Entities.Project", "Project")
                        .WithMany("ProjectMembers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.ProjectRequirement", b =>
                {
                    b.HasOne("Collaboo.App.WebAPI.Entities.Project")
                        .WithMany("Requirements")
                        .HasForeignKey("ProjectId");

                    b.HasOne("Collaboo.App.WebAPI.Entities.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.UserFollowers", b =>
                {
                    b.HasOne("Collaboo.App.WebAPI.Entities.Follower", "Follower")
                        .WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Collaboo.App.WebAPI.Entities.UserSkills", b =>
                {
                    b.HasOne("Collaboo.App.WebAPI.Entities.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Collaboo.App.WebAPI.Entities.User", "User")
                        .WithMany("UserSkills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
