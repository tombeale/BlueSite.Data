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

        public bool Active { get; set; } = true;

        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(10)]
        public string Zip { get; set; }

		[MaxLength(20)]
		public string Phone { get; set; }
		[MaxLength(100)]
		public string Email { get; set; }
		[MaxLength(250)]
		public string Website { get; set; }

    }
}
