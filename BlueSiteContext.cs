﻿using Microsoft.EntityFrameworkCore;

namespace BlueSite.Data.Entities
{
    public class BlueSiteContext: DbContext
    {
        public DbSet<ActionItem> ActionItems { get; set; }
        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<ActionItemNotes> ActionItemNotes { get; set; }
        public BlueSiteContext(DbContextOptions<BlueSiteContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionItemNotes>()
                .HasKey(na => new {na.ActionItemId, na.NoteId});
            modelBuilder.Entity<ActionItemNotes>()
                .HasOne(an => an.Note)
                .WithMany(n => n.ActionItemNotes)
                .HasForeignKey(bc => bc.ActionItemId);
            modelBuilder.Entity<ActionItemNotes>()
                .HasOne(an => an.ActionItem)
                .WithMany(a => a.ActionItemNotes)
                .HasForeignKey(bc => bc.NoteId);
        }


    }
}
