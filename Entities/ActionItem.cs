using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSite.Data.Entities
{
    public class ActionItem
    {
        [Key]
        public int? ActionItemId { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type {  get; set; } = "todo";
        [MaxLength(50)]
        public string SetId { get; set; }
        public DateTime? StartDate {  get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        [MaxLength(50)]
        public string SearchID { get; set; }
        public bool IsDone { get; set; } = false;
        public int? Parent { get; set; }

        public int? CampaignId { get; set; }
        public int? ContactId { get; set; }

        //public ICollection<Company> Companies { get; set; }
        //public ICollection<Contact> Contacts { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<ActionItemNotes> ActionItemNotes { get; set; }
    }
}
