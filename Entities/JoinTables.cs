﻿using System;
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
}
