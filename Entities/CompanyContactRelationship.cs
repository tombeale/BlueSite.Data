using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class CompanyContactRelationship
    {
        [Key]
        public int CompanyId { get; set; }

        [Key]
        public int ContactId { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

        public string Notes { get; set; }

    }
}
