using System;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class LanguageEntry
    {
        [Key]
        public int LanguageEntryId { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Key { get; set; }

        public int BaseYear { get; set; }

        public bool IsEstimate { get; set; } = false;

        public string Text { get; set; }

        public bool IsValid()
        {
            if (String.IsNullOrEmpty(Name)) return false;
            if (String.IsNullOrEmpty(Key))  return false;
            if (String.IsNullOrEmpty(Text)) return false;
            return true;
        }
    }
}
