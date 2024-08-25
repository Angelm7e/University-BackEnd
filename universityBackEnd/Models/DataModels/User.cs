using System.ComponentModel.DataAnnotations;

namespace universityBackEnd.Models.DataModels
{
    public class User :BaseEntity
    {
        [Required]
        public string name { get; set; }
        public string lastName { get; set; }
        [Required, EmailAddress]
        public string emailAddress { get; set; }
        [Required]
        public string password { get; set; }
    }
}
