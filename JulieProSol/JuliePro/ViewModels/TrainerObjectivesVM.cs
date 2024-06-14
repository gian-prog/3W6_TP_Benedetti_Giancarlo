using JuliePro.Models;
namespace JuliePro.ViewModels
{
    public class TrainerObjectivesVM
    {
        public Trainer Trainers { get; set; }
        public Objective Objective { get; set; }
        public IEnumerable<CustomerObjectivesVM> customerObjectives { get; set; }

    }
}
