using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Key  { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name  { get; set; }
    }
}
