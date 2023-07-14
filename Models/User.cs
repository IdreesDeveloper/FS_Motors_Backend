using System.ComponentModel.DataAnnotations;

namespace FS_Motors.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public double Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
