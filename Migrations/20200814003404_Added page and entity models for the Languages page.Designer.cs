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
    [Migration("20200814003404_Added page and entity models for the Languages page")]
    partial class AddedpageandentitymodelsfortheLanguagespage
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

                    b.Property<int?>("CampaignId");

                    b.Property<int?>("ContactId");

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("IsDone");

                    b.Property<string>("Outcome");

                    b.Property<int?>("Parent");

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

                    b.HasIndex("CampaignId");

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

            modelBuilder.Entity("BlueSite.Data.Entities.ActionSetId", b =>
                {
                    b.Property<int>("ActionSetID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("SetId")
                        .HasMaxLength(50);

                    b.HasKey("ActionSetID");

                    b.ToTable("ActionSetIds");
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

            modelBuilder.Entity("BlueSite.Data.Entities.Campaign", b =>
                {
                    b.Property<int>("CampaignId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<string>("CompanyName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Notes");

                    b.Property<string>("Position")
                        .HasMaxLength(160);

                    b.Property<string>("RefNumber")
                        .HasMaxLength(80);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Status")
                        .HasMaxLength(50);

                    b.HasKey("CampaignId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.CampaignActionRelationship", b =>
                {
                    b.Property<int>("CampaignActionRelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionId");

                    b.Property<int>("CampaignId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("CampaignActionRelationshipId");

                    b.ToTable("CampaignActionRelationships");
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

                    b.Property<int?>("ContactId");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Interest")
                        .HasMaxLength(50);

                    b.Property<string>("Location");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("Notes");

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

                    b.HasIndex("ContactId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.CompanyActionRelationship", b =>
                {
                    b.Property<int>("CompanyId");

                    b.Property<int>("ActionId");

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.Property<string>("Notes");

                    b.Property<string>("Type")
                        .HasMaxLength(40);

                    b.HasKey("CompanyId", "ActionId");

                    b.HasAlternateKey("ActionId", "CompanyId");

                    b.ToTable("CompanyActionRelationship");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.CompanyContactRelationship", b =>
                {
                    b.Property<int>("CompanyId");

                    b.Property<int>("ContactId");

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.Property<string>("Notes");

                    b.HasKey("CompanyId", "ContactId");

                    b.ToTable("CompanyContactRelationships");
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

            modelBuilder.Entity("BlueSite.Data.Entities.CompanyPhones", b =>
                {
                    b.Property<int>("CompanyId");

                    b.Property<int>("PhoneId");

                    b.Property<int?>("CompanyId2");

                    b.HasKey("CompanyId", "PhoneId");

                    b.HasIndex("CompanyId2");

                    b.HasIndex("PhoneId");

                    b.ToTable("CompanyPhones");
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

                    b.Property<string>("Address1")
                        .HasMaxLength(50);

                    b.Property<string>("Address2")
                        .HasMaxLength(50);

                    b.Property<int?>("CampaignId");

                    b.Property<string>("City")
                        .HasMaxLength(50);

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

                    b.Property<string>("State")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasMaxLength(40);

                    b.Property<string>("Website")
                        .HasMaxLength(250);

                    b.Property<string>("Zip")
                        .HasMaxLength(10);

                    b.HasKey("ContactId");

                    b.HasIndex("CampaignId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ContactActionRelationship", b =>
                {
                    b.Property<int>("ContactId");

                    b.Property<int>("ActionId");

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.Property<string>("Notes");

                    b.Property<string>("Type")
                        .HasMaxLength(40);

                    b.HasKey("ContactId", "ActionId");

                    b.HasAlternateKey("ActionId", "ContactId");

                    b.ToTable("ContactActionRelationship");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ContactPhones", b =>
                {
                    b.Property<int>("ContactId");

                    b.Property<int>("PhoneId");

                    b.HasKey("ContactId", "PhoneId");

                    b.HasIndex("PhoneId");

                    b.ToTable("ContactPhones");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ContactType", b =>
                {
                    b.Property<int>("ContactTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactTypeKey")
                        .HasMaxLength(50);

                    b.Property<string>("ContactTypeName")
                        .HasMaxLength(50);

                    b.Property<int?>("Order");

                    b.HasKey("ContactTypeId");

                    b.ToTable("ContactTypes");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.LanguageEntry", b =>
                {
                    b.Property<int>("LanguageEntryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BaseYear");

                    b.Property<bool>("IsEstimate");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<string>("Text");

                    b.HasKey("LanguageEntryId");

                    b.ToTable("LanguageEntries");
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

                    b.HasIndex("ContactId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<int?>("ContactId");

                    b.Property<string>("Ext")
                        .HasMaxLength(5);

                    b.Property<string>("Number")
                        .HasMaxLength(20);

                    b.Property<string>("Type")
                        .HasMaxLength(20);

                    b.HasKey("PhoneId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ContactId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.PhoneType", b =>
                {
                    b.Property<string>("Type")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("SortOrder");

                    b.HasKey("Type");

                    b.ToTable("PhoneTypes");
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

            modelBuilder.Entity("BlueSite.Data.Entities.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasMaxLength(50);

                    b.Property<string>("ListType")
                        .HasMaxLength(10);

                    b.Property<int>("ParentId");

                    b.Property<string>("ParentType")
                        .HasMaxLength(20);

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.TopicPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Done");

                    b.Property<string>("Notes");

                    b.Property<int>("Order");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("TopicPoints");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Address1");

                    b.Property<string>("Address2")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastSignon");

                    b.Property<string>("LasttName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("SignOn")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("State")
                        .HasMaxLength(50);

                    b.Property<string>("Website")
                        .HasMaxLength(250);

                    b.Property<string>("Zip")
                        .HasMaxLength(10);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.UserPref", b =>
                {
                    b.Property<int>("UserPrefId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pref")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("UserPrefId");

                    b.HasIndex("UserId", "Pref")
                        .IsUnique();

                    b.ToTable("UserPrefs");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ActionItem", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Campaign", null)
                        .WithMany("Actions")
                        .HasForeignKey("CampaignId");
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

            modelBuilder.Entity("BlueSite.Data.Entities.Company", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Contact", null)
                        .WithMany("Companies")
                        .HasForeignKey("ContactId");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.CompanyPhones", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Phone", "Phone")
                        .WithMany("CompanyPhones")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueSite.Data.Entities.Company", null)
                        .WithMany("ContactPhones")
                        .HasForeignKey("CompanyId2");

                    b.HasOne("BlueSite.Data.Entities.Company", "Company")
                        .WithMany("CompanyPhones")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Contact", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Campaign", null)
                        .WithMany("Contacts")
                        .HasForeignKey("CampaignId");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.ContactPhones", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Phone", "Phone")
                        .WithMany("ContactPhones")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueSite.Data.Entities.Contact", "Contact")
                        .WithMany("ContactPhones")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Note", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.ActionItem", "Action")
                        .WithMany("Notes")
                        .HasForeignKey("ActionItemId");

                    b.HasOne("BlueSite.Data.Entities.Contact", null)
                        .WithMany("Notes")
                        .HasForeignKey("ContactId");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.Phone", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Company", "Company")
                        .WithMany("Phones")
                        .HasForeignKey("CompanyId");

                    b.HasOne("BlueSite.Data.Entities.Contact", null)
                        .WithMany("Phones")
                        .HasForeignKey("ContactId");
                });

            modelBuilder.Entity("BlueSite.Data.Entities.TopicPoint", b =>
                {
                    b.HasOne("BlueSite.Data.Entities.Topic", null)
                        .WithMany("Topics")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
