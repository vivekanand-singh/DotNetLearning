using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_learning.model
{
    public class PaymentDetail
    {
        [Key]
        public int paymentId { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public String cardOwner { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public String cardNumber {get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public String expiryDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public String cvv { get; set; }
    }
}
