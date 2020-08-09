using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Caption { get; set; } = "";

        [Required]
        public string Text { get; set; }

        [MaxLength(20)]
        public string ParentType { get; set; } = "action";

        public List<TopicPoint> Topics { get; set; }

        [MaxLength(10)]
        public string ListType { get; set; } = "U";

        [Required]
        public int ParentId { get; set; }
    }
}
