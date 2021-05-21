﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Surveymatic.Data;

namespace Surveymatic.Migrations
{
    [DbContext(typeof(HelpContext))]
    [Migration("20210521004244_admin_migration")]
    partial class admin_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Surveymatic.Model.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnswerInt")
                        .HasColumnType("int");

                    b.Property<string>("AnswerTxt")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Surveymatic.Model.Help", b =>
                {
                    b.Property<int>("HelpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HelpTag")
                        .HasColumnType("longtext");

                    b.HasKey("HelpId");

                    b.ToTable("Help");
                });

            modelBuilder.Entity("Surveymatic.Model.HelpEntry", b =>
                {
                    b.Property<int>("HelpEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<int?>("HelpId")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("longtext");

                    b.HasKey("HelpEntryId");

                    b.HasIndex("HelpId");

                    b.ToTable("HelpEntry");
                });

            modelBuilder.Entity("Surveymatic.Model.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Surveymatic.Model.QuestionTranslation", b =>
                {
                    b.Property<int>("QuestionTranslatonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("longtext");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("QuestionTranslatonId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionTranslations");
                });

            modelBuilder.Entity("Surveymatic.Model.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SurveyId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Surveymatic.Model.SurveyTranslation", b =>
                {
                    b.Property<int>("SurveyTranslationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Instruction")
                        .HasColumnType("longtext");

                    b.Property<string>("Language")
                        .HasColumnType("longtext");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("SurveyTranslationId");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyTranslations");
                });

            modelBuilder.Entity("Surveymatic.Model.Answer", b =>
                {
                    b.HasOne("Surveymatic.Model.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Surveymatic.Model.HelpEntry", b =>
                {
                    b.HasOne("Surveymatic.Model.Help", "Help")
                        .WithMany("Entries")
                        .HasForeignKey("HelpId");

                    b.Navigation("Help");
                });

            modelBuilder.Entity("Surveymatic.Model.Question", b =>
                {
                    b.HasOne("Surveymatic.Model.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Surveymatic.Model.QuestionTranslation", b =>
                {
                    b.HasOne("Surveymatic.Model.Question", "Question")
                        .WithMany("QuestionTranslations")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Surveymatic.Model.SurveyTranslation", b =>
                {
                    b.HasOne("Surveymatic.Model.Survey", "Survey")
                        .WithMany("SurveyTranslations")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Surveymatic.Model.Help", b =>
                {
                    b.Navigation("Entries");
                });

            modelBuilder.Entity("Surveymatic.Model.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("QuestionTranslations");
                });

            modelBuilder.Entity("Surveymatic.Model.Survey", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("SurveyTranslations");
                });
#pragma warning restore 612, 618
        }
    }
}
