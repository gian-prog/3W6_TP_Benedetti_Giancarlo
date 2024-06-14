using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Speciality
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage ="The Speciality's {0} must have a length included in between {2} and {1} characters")]
        public string Name { get; set; }
    }
}
