using BlueSite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSite.Data.Interfaces
{
    public interface IBlueSiteContext
    {
        DbSet<ActionItem> ActionItems { get; set; }
        DbSet<ActionType> ActionTypes { get; set; }
        DbSet<Note> Notes { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<ActionItem> ActionItemNotes { get; set; }
    }

}