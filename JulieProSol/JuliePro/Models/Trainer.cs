using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "The {0} of the trainer must have a length between {2} and {1} characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "The {0} of the trainer must have a length between {2} and {1} characters")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(40, ErrorMessage = "The trainer's {0} has a maximum length of {1} characters")]
        public string Photo { get; set; }

        public int SpecialityId { get; set; }
        [ValidateNever]
        public virtual Speciality Speciality { get; set; }
    }
}
