using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FS_Motors.Models
{
    public class Car
    {

        [Key]
        public string CarId { get; set; }

        [ForeignKey("CarModel")]
        public string CarModelId { get; set; }
        public CarModelType CarModelType { get; set; }

        public int CarBuyingPrice { get; set; }
        public int? CarMaintenanceCost { get; set; }
        public int? CarShowroomCost { get; set; }
        public int CarTotalCost { get; set; }
        public int? CarFinalPrice { get; set; }
        public int? CarSellingPrice { get; set; }
        public DateTime? CarBuyingDate { get; set; }
        public DateTime? CarSellingDate { get; set; }

        [ForeignKey("Workshop")]
        public string CarWorkshopId { get; set; }
        public WorkShop WorkShop { get; set; }

        public string CarStatus { get; set; }

        [ForeignKey("Showroom")]
        public int? CarShowroomId { get; set; }
        public Showroom Showroom { get; set; }
    }
}
