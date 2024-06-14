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
            var trainers = _context.Trainer.Include(t => t.Customer).ThenInclude(t=>t.Speciality).Select(t => new TrainerObjectivesVM()
            {
                Trainers = t
            });
            return View(await trainers.ToListAsync());
        }
    }
}
