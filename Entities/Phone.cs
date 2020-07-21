using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }

        [MaxLength(20)]
        public string Number { get; set; }
        [MaxLength(5)]
        public string Ext { get; set; }
        [MaxLength(20)]
        public string Type { get; set; }

        public Company Company {  get; set; }
        public int? CompanyId {  get; set; }

        public int? ContactId {  get; set; }

        public IEnumerable<CompanyPhones> CompanyPhones {  get; set; }
        public IEnumerable<ContactPhones> ContactPhones {  get; set; }

        public Phone()
        {
        }
        public Phone(string number, string type)
        {
            Number = number;
            Type = type;
        }
    }
}
