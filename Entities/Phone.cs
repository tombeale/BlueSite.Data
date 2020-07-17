using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Phone
    {
        [Key]
        [MaxLength(20)]
        public string Number { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }

        public int? ContactId;

        public int? CompanyId; 
    }
}
