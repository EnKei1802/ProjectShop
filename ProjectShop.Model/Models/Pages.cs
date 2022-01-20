

using ProjectShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectShop.Model.Models
{
    [Table("Pages")]
    public class Pages:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }
        public string Content { get; set; }
    }
}
