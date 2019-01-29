using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ghEntities.Models
{
    [Table("ghArchive")]
    public class ghArchive
    {
        [Key]
        public Guid RUID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(150, ErrorMessage = "Name can not be longer 150 characters")]
        public string Name { get; set; }
        [StringLength(100)]
        public string Type { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        
        public Nullable<DateTime> DeletedDate { get; set; }
        public string DeletedBy { get; set; }
    }
}
