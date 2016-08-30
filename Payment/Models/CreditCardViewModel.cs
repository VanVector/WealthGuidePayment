using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Payment.Models
{
    public class CreditCardViewModel
    {
        [CreditCard]
        [Required]
        public string Number { get; set; }
        [RegularExpression("([0-9]+)", ErrorMessage = "The field {0} is incorrect.")]
        [Required]
        public int CVC { get; set; }
        [RegularExpression("([0-9]{1,2})", ErrorMessage = "The field {0} is incorrect.")]
        [Required]
        [DisplayName("Expiration Month")]
        public int ExiprationMonth { get; set; }
        [RegularExpression("([0-9]{4})", ErrorMessage = "The field {0} is incorrect.")]
        [Required]
        [DisplayName("Expiration Year")]
        public int ExpirationYear { get; set; }
    }
}