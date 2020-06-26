using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSite.Data.Entities
{
    public class MenuItem
    {
        public string Id { get; set; }
        public string Icon { get; set; }
        public string Caption { get; set; }
        public string Action { get; set; }
        public string Type { get; set; } = "link";
        public string Parent { get; set; } = "";

        public MenuItem(string id, string icon, string caption, string action, string type = "link", string parent = "" )
        {
            Id = id;
            Icon = icon;
            Caption = caption;
            Action = action;
            Type = type;
            Parent = parent;
        }

    }
}
