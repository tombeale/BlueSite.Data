using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSite.Data.Entities
{
    class ActionNote
    {
        public int ActionItemId { get; set; }
        public int NoteId { get; set; }
        public Action ActionItem { get; set; }
        public Note Note { get; set; }

    }
}
