using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Note
    {
        [Key]
        public int NoteId {  get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        [MaxLength(25)]
        public string User { get; set; } = "tom";
        [MaxLength(20)]
        public string Type { get; set; } = "note";
        public string Text { get; set; } = "";

        public int? CompanyId { get; set; }
        public int? ContactId { get; set; }
        public int? ActionItemId { get; set; }
        public ActionItem Action { get; set; }

        public ICollection<ActionItemNotes> ActionItemNotes { get; set; }
    }
}
