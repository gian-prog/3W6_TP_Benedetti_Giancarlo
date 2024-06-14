using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 4, ErrorMessage = "The {0} of the customer must have a length included in between {2} and {1} characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "The {0} of the customer must have a length included in between {2} and {1} characters")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        [Range(100, 400, ErrorMessage = "The customer's starting weight must be between {1} and {2}")]
        public double StartWeight { get; set; }

        public int TrainerId { get; set; }
        [ValidateNever]
        public virtual Trainer Trainer { get; set; }


    }
}
