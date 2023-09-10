using System.ComponentModel.DataAnnotations;

namespace FS_Motors.Models
{
    public class CarModelType
    {
        [Key]
        public string CarModelId { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CarName { get; set; }
        public DateTime CarMakeYear { get; set; }
        public string CarType { get; set; }
        public string CarEngineHorsepower { get; set; }
        public string CarSeatingCapacity { get; set; }
        public string CarTransmissionType { get; set; }
    }
}
