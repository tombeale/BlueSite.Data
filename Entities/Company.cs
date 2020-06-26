using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class Company
    {
        public int CompanyId {  get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(25)]
        public string Type { get; set; }

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

        [MaxLength(25)]
        public string SearchId { get; set; }

        //public ICollection<Contact> Contacts { get; set; }
        //public ICollection<Note> Notes { get; set; }
    }
}
