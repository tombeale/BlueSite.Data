using System;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Note
    {
        public int NoteId {  get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        [MaxLength(25)]
        public string User { get; set; }
        [MaxLength(20)]
        public string Type { get; set; }
        public int ParentId { get; set; }
        public string Text { get; set; }

        public int? CompanyId { get; set; }
        public int? ContactId { get; set; }
        public int? ActionItemId { get; set; }
        public ActionItem Action { get; set; }
    }
}
