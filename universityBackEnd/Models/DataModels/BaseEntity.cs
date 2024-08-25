using System.ComponentModel.DataAnnotations;

namespace universityBackEnd.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key] 
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string updatedBy { get; set; }
        public string? deletedBy {  get; set; }
        public DateTime createdDate { get; set; } = DateTime.Now;
        public DateTime updatedDate { get; set; } = DateTime.Now;
        public DateTime deletedAt { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
