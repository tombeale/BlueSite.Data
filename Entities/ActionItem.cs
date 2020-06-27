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
        public string Title { get; set; }
        [Required]
        public string Type {  get; set; } = "todo";
        public string SetId { get; set; }
        public DateTime? StartDate {  get; set; }
        public DateTime? EndDate { get; set; }
        public string status { get; set; }
        public string SearchID { get; set; }
        public bool IsDone { get; set; } = false;

        //public ICollection<Company> Companies { get; set; }
        //public ICollection<Contact> Contacts { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<ActionItemNotes> ActionItemNotes { get; set; }
    }
}
