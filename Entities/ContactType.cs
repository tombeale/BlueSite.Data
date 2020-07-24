using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class ContactType
    {
        [Key]
        public int ContactTypeId {  get; set; }
        [MaxLength(50)]
        public string ContactTypeKey {  get; set; }
        [MaxLength(50)]
        public string ContactTypeName {  get; set; }
        public int? Order { get; set; }
    }
}
