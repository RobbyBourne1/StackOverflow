﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StackOverflow.DataContext;
using System;

namespace StackOverflow.Migrations
{
    [DbContext(typeof(StackOverflowContext))]
    [Migration("20170905154304_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("StackOverflow.Models.AnswersModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("PostDate");

                    b.Property<int>("UserId");

                    b.Property<int?>("UserModelId");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("StackOverflow.Models.CommentsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AnswersModelId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("PostDate");

                    b.Property<int>("UserId");

                    b.Property<int?>("UserModelId");

                    b.HasKey("Id");

                    b.HasIndex("AnswersModelId");

                    b.HasIndex("UserModelId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("StackOverflow.Models.QtiesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestionId");

                    b.Property<int?>("QuestionModelId");

                    b.Property<int>("TagsId");

                    b.Property<int?>("TagsModelId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionModelId");

                    b.HasIndex("TagsModelId");

                    b.ToTable("Qties");
                });

            modelBuilder.Entity("StackOverflow.Models.QuestionsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("PostDate");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.Property<int?>("UserModelId");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("StackOverflow.Models.TagsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TagName");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("StackOverflow.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsModerator");

                    b.Property<string>("LastName");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StackOverflow.Models.AnswersModel", b =>
                {
                    b.HasOne("StackOverflow.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("StackOverflow.Models.CommentsModel", b =>
                {
                    b.HasOne("StackOverflow.Models.AnswersModel", "AnswersModel")
                        .WithMany()
                        .HasForeignKey("AnswersModelId");

                    b.HasOne("StackOverflow.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("StackOverflow.Models.QtiesModel", b =>
                {
                    b.HasOne("StackOverflow.Models.QuestionsModel", "QuestionModel")
                        .WithMany()
                        .HasForeignKey("QuestionModelId");

                    b.HasOne("StackOverflow.Models.TagsModel", "TagsModel")
                        .WithMany()
                        .HasForeignKey("TagsModelId");
                });

            modelBuilder.Entity("StackOverflow.Models.QuestionsModel", b =>
                {
                    b.HasOne("StackOverflow.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
