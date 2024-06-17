using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro.Models;
using JuliePro.ViewModels;


namespace JuliePro.Controllers
{
    public class ObjectivesController : Controller
    {
        private readonly MyDbContext _context;

        public ObjectivesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Objectives
        public async Task<IActionResult> AllObjectives()
        {
            List<TrainerObjectivesVM> tlst = new List<TrainerObjectivesVM>();
            foreach (Trainer t in _context.Trainer.Include(t => t.Speciality))
            {
                List<CustomerObjectivesVM> clst = new List<CustomerObjectivesVM>();
                foreach (Customer c in _context.Customer.Where(C => C.TrainerId == t.Id))
                {
                    clst.Add(new CustomerObjectivesVM() { Customers = c, Objectives = _context.Objective.Where(o => o.CustomerId == c.Id).ToList() });

                }
                tlst.Add(new TrainerObjectivesVM
                {
                    Trainers = t,
                    customerObjectives = clst

                });
            }

            return View(tlst);
        }
    }
}
