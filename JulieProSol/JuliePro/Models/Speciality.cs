using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Speciality
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage ="Le nom de la spécialité doit être compris entre {2} et {1} caractères")]
        public string Name { get; set; }
    }
}
