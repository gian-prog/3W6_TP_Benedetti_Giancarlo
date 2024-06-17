using JuliePro.Models;
namespace JuliePro.ViewModels
{
    public class TrainerObjectivesVM
    {
        public Trainer Trainers { get; set; }
        public Objective Objective { get; set; }
        public List<CustomerObjectivesVM> customerObjectives { get; set; }

    }
}
