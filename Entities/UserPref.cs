
using System.ComponentModel.DataAnnotations;

namespace BlueSite.Data.Entities
{
    public class UserPref
    {
        [Key]
        public int UserPrefId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Pref { get; set; }

        public string Value { get; set; }

        public UserPref(int userId, string pref, string value)
        {
            UserId = userId;
            Pref   = pref;
            Value  = value;
        }
    }
}
