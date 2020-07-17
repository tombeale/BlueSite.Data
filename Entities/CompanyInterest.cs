using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class CompanyInterest
    {
        [Key]
        [MaxLength(50)]
        public string CompanyInterestId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? Order { get; set; }

        public CompanyInterest(string companyInterestId, string name)
        {
            CompanyInterestId = companyInterestId;
            Name = name;
        }
    }
}
