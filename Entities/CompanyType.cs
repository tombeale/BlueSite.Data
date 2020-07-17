using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class CompanyType
    {
        [Key]
        [MaxLength(50)]
        public string CompanyTypeId {  get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? Order { get; set; }

        public CompanyType(string companyTypeId, string name)
        {
            CompanyTypeId = companyTypeId;
            Name = name;

        }
    }
}
