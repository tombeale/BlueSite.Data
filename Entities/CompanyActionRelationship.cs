using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class CompanyActionRelationship
    {
        [Key]
        public int CompanyId { get; set; }

        [Key]
        public int ActionId { get; set; }

        [MaxLength(40)]
        public string Type { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

        public string Notes { get; set; }

    }
}
