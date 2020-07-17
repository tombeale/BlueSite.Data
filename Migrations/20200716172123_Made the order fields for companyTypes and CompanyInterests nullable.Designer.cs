﻿// <auto-generated />
using System;
using BlueSite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlueSite.Data.Migrations
{
    [DbContext(typeof(BlueSiteContext))]
    [Migration("20200716172123_Made the order fields for companyTypes and CompanyInterests nullable")]
    partial class MadetheorderfieldsforcompanyTypesandCompanyInterestsnullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlueSite.Data.Entities.ActionItem", b =>
                {
                    b.Property<int?>("ActionItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("IsDone");

                    b.Property<int?>("Parent");

                    b.Property<int?>("ProjectId");

                    b.Property<string>("SearchID")
                        .HasMaxLength(50);

                    b.Property<string>("SetId")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("StartDate");

                    b.Property<string>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ActionItemId");

                    b.ToTable("ActionItems");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ActionItemNotes", b =>
                {
                    b.Property<int>("ActionItemId");

                    b.Property<int>("NoteId");

                    b.HasKey("ActionItemId", "NoteId");

                    b.HasIndex("NoteId");

                    b.ToTable("ActionItemNotes");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ActionType", b =>
                {
                    b.Property<string>("ActionTypeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Order");

                    b.HasKey("ActionTypeId");

                    b.ToTable("ActionTypes");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasMaxLength(50);

                    b.Property<string>("Address2")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Interest")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("SearchId")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.Property<string>("Website")
                        .HasMaxLength(250);

                    b.Property<string>("Zip")
                        .HasMaxLength(10);

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.CompanyInterest", b =>
                {
                    b.Property<string>("CompanyInterestId")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Order");

                    b.HasKey("CompanyInterestId");

                    b.ToTable("CompanyInterests");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.CompanyType", b =>
                {
                    b.Property<string>("CompanyTypeId")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Order");

                    b.HasKey("CompanyTypeId");

                    b.ToTable("CompanyTypes");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("SearchID")
                        .HasMaxLength(25);

                    b.Property<string>("Title")
                        .HasMaxLength(40);

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActionItemId");

                    b.Property<int?>("CompanyId");

                    b.Property<int?>("ContactId");

                    b.Property<string>("Text");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Type")
                        .HasMaxLength(20);

                    b.Property<string>("User")
                        .HasMaxLength(25);

                    b.HasKey("NoteId");

                    b.HasIndex("ActionItemId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int?>("Parent");

                    b.Property<DateTime?>("StartDate");

                    b.Property<string>("Status")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ActionItemNotes", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Note", "Note")
                        .WithMany("ActionItemNotes")
                        .HasForeignKey("ActionItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueSite.Data.Entities.ActionItem", "ActionItem")
                        .WithMany("ActionItemNotes")
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Note", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.ActionItem", "Action")
                        .WithMany("Notes")
                        .HasForeignKey("ActionItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
