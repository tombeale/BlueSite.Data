using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class User
    {
        [Key]
        public int UserId {  get; set; }
        
        [Required]
        [MaxLength(30)]
        public string SignOn { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LasttName { get; set; }

        public DateTime? LastSignon { get; set; }

    }
}
