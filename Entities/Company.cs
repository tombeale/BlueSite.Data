using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Company
    {
        [Key]
        public int CompanyId {  get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(50)]
        public string Interest { get; set; }

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
        [MaxLength(250)]
        public string Website { get; set; }
        public string Location { get; set; }
        [MaxLength(25)]
        public string SearchId { get; set; }

        public List<Phone> Phones { get; set; }
        public IEnumerable<CompanyPhones> CompanyPhones {  get; set; }
        public IEnumerable<CompanyPhones> ContactPhones {  get; set; }

        public string Notes { get; set; }
    }
}
