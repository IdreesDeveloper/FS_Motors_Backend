using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FS_Motors.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("Car")]
        [Column("CarId")]
        [MaxLength(20)]
        public string CarId { get; set; }
        public Car Car { get; set; }

        [ForeignKey("Investor")]
        [Column("BuyerId")]
        [MaxLength(20)]
        public string BuyerId { get; set; }
        public Investor Investor { get; set; }

        [Column("TransactionDate")]
        public DateTime? TransactionDate { get; set; }

        [Column("BuyerAddress")]
        [MaxLength(50)]
        public string BuyerAddress { get; set; }

        [Column("TaxRate")]
        public int? TaxRate { get; set; }

        [Column("IsPurchase")]
        public bool? IsPurchase { get; set; }

        [Column("TotalAmount")]
        public int? TotalAmount { get; set; }
    }
}
