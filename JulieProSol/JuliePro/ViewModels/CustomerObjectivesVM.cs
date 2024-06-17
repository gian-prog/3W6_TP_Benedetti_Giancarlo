using JuliePro.Models;
namespace JuliePro.ViewModels
{
    public class CustomerObjectivesVM
    {
        public Customer Customers { get; set; }
        public List<Objective> Objectives { get; set; }

        public int NbreAchieved(List<Objective> pList)
        {
            int cpt = 0;
            foreach (var item in pList)
            {
                if (item.AchievedDate != null)
                {
                    cpt++;
                }
            }
            return cpt;
        }
        public int NbreUnachieved(List<Objective> pList)
        {
            int cpt = 0;
            foreach (var item in pList)
            {
                if (item.AchievedDate == null)
                {
                    cpt++;
                }
            }
            return cpt;
        }
    }
}
