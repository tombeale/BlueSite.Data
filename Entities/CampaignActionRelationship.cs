using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class CampaignActionRelationship
    {
        [Key]
        public int CampaignActionRelationshipId {  get; set; }

        [Required]
        public int CampaignId {  get; set; }

        [Required]
        public int ActionId {  get; set; }

        [Required]
        [MaxLength(255)]
        public string Description {  get; set; }
    }
}
