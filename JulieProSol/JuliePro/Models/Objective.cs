using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Objective
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "The {0} of the objective must have a length longer than {2} and not exceed {1} characters.")]
        public string Name { get; set; }

        [Range(2, 10, ErrorMessage = "The objective's lost weight(in kilograms) must be between {1} and {2}")]
        public double LostWeightKg { get; set; }

        [Range(2, 45, ErrorMessage = "The distance of the objective must be between {1} and {2} kilometers")]
        public double DistanceKm { get; set; }

        public DateTime? AchievedDate { get; set; }

        public int CustomerId { get; set; }
        [ValidateNever]
        public virtual Customer Customer { get; set; }
    }
}
