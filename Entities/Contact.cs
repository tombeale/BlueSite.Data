using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Contact
    {
		public int ContactId { get; set; }
		[MaxLength(40)]
		public string FirstName { get; set; }
		[MaxLength(40)]
		public string LastName { get; set; }
		[MaxLength(40)]
		public string Title { get; set; }
		[MaxLength(20)]
		public string Phone { get; set; }
		[MaxLength(100)]
		public string Email { get; set; }
		public bool Active { get; set; }
		[MaxLength(25)]
		public string SearchID { get; set; }

		//public ICollection<Company> Companies { get; set; }
		//public ICollection<Note> Notes { get; set; }
	}
}
