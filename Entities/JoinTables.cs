using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class ActionItemNotes
    {
        public int ActionItemId { get; set; }
        public ActionItem ActionItem { get; set; }
        public int NoteId { get; set; }
        public Note Note { get; set; }

    }
    public class CompanyPhones
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }

    public class ContactPhones
    {
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }

    }
}
