using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class PhoneType
    {
        [Key]
        [MaxLength(20)]
        public string Type {  get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? SortOrder { get; set; }
    }
}
