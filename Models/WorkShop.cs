using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FS_Motors.Models
{
    public class WorkShop
    {
        [Key]
        [Column("WorkShopId")]
        public int WorkShopId { get; set; }

        [Required]
        [Column("WorkShopName")]
        [MaxLength(20)]
        public string WorkShopName { get; set; }

        [Required]
        [Column("WorkshopLocation")]
        [MaxLength(20)]
        public string WorkshopLocation { get; set; }
    }
}
