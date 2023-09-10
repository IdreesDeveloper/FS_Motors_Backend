using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FS_Motors.Models
{
    public class UserType
    {
        [Key]
        public int user_typeid { get; set; } //primary
        public string User_type { get; set; } //admin, investor, buyer
        public int? User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User{ get; set;}
    }
}
