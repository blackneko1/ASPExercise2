using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPExercise2.Models
{
    public class RegisterClass
    {
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$",ErrorMessage = "First Name Invalid"), Required, StringLength(20)]
        public string firstname { get; set; }

        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Middle Name Invalid"), Required, StringLength(20)]
        public string middlename { get; set; }

        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Last Name Invalid"), Required, StringLength(20)]
        public string lastname { get; set; }

        [RegularExpression(@"^(0?[1-9]|[1-9][0-9]|[1][1-9][1-9]|150)$", ErrorMessage = "Age Must 1-150"), Required]
        public string age { get; set; }

        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Example Mambaling, Pardo, Talisay"), Required]
        public string address { get; set; }

        [RegularExpression(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", ErrorMessage = "Invalid Number Example 09184540243"), Required]
        public string contactnumber { get; set; }

        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{3}", ErrorMessage = "Invalid Email Example john@xxxxx.com"), Required]
        [EmailAddress]
        public string emailaddress { get; set; }
    }
}
