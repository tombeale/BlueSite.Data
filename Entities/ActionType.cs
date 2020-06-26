using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class ActionType
    {
        public string ActionTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Order { get; set; }
        public ActionType(string actionTypeId, string name, int order = 0)
        {
            ActionTypeId = actionTypeId;
            Name = name;
            Order = order;

        }
    }
}
