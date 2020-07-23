using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Contact
    {
		[Key]
		public int ContactId { get; set; }
		[MaxLength(40)]
		public string FirstName { get; set; }
		[MaxLength(40)]
		public string LastName { get; set; }
		[MaxLength(40)]
		public string Title { get; set; }

        [MaxLength(50)]
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
		public bool Active { get; set; }
		[MaxLength(25)]
		public string SearchID { get; set; }

		public ICollection<Company> Companies { get; set; }
        public List<Phone> Phones { get; set; }
		public List<Note> Notes { get; set; }

		public List<ContactPhones> ContactPhones { get; set; }
	}
}
