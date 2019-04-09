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
        public string cardOwner { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string cardNumber {get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string expiryDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string cvv { get; set; }
    }
}
