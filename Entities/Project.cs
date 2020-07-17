using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        public int? Parent { get; set; }
    }
}
