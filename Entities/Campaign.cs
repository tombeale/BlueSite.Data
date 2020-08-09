using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class Campaign
    {
        [Key]
        public int CampaignId {  get; set; }

        [Required]
        [MaxLength(100)]
        public string Name {  get; set; }

        [MaxLength(50)]
        public string Status {  get; set; }

        public int? CompanyId { get; set; }

        public string CompanyName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [MaxLength(160)]
        public string Position { get; set; }

        [MaxLength(80)]
        public string RefNumber { get; set; }

        public string Notes { get; set; }

        public List<Contact> Contacts { get; set; } 

        public List<ActionItem> Actions { get; set; } 
    }
}
