using Microsoft.EntityFrameworkCore;

namespace BlueSite.Data.Entities
{
    public class BlueSiteContext: DbContext
    {
        public DbSet<ActionItem> ActionItems { get; set; }
        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }
        public BlueSiteContext(DbContextOptions<BlueSiteContext> options)
            : base(options)
        { }




    }
}
