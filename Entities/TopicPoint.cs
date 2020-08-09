using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class TopicPoint
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Text { get; set; }

        public bool Done { get; set; } = false;

        public int Order { get; set; } = 999;

        [Required]
        public int TopicId { get; set; }
        public string Notes { get; set; }


        public TopicPoint() { }

        public TopicPoint(int topicId)
        {
            TopicId = topicId;
        }

        public TopicPoint(TopicPoint point)
        {
            Text    = (point.Text != null) ? point.Text : "";
            Done    = false;
            Order   = point.Order;
            TopicId = point.TopicId;
            Notes   = point.Notes;
        }
    }
}
