using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }


        [DisplayName("Account Number")]
        [Column(TypeName = "nvarchar(12)")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        public string AccountNumber { get; set; }


        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }


        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(12)")]
        [Required(ErrorMessage = "This field is required")]
        public string BankName { get; set; }


        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only")]
        public string SWIFTCode { get; set; }


        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }


        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy")]
        public DateTime Date { get; set; }
       
        





    }
}
