using System.ComponentModel.DataAnnotations;

namespace FS_Motors.Models
{
    public class Showroom
    {
        [Key]
        public string ShowroomId { get; set; }
        public string ShowroomName { get; set; }
        public string ShowroomAddress { get; set; }
    }
}
