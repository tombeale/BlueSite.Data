using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BlueSite.Data.Entities
{
    public class ActionSetId
    {
        [Key]
        public int ActionSetID { get; set; }

        [MaxLength(50)]
        public string SetId {  get; set; }

        [MaxLength(50)]
        public string Name {  get; set; }
    }
}
