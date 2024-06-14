using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro.Models;

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
            var myDbContext = _context.Objective.Include(o => o.Customer);
            return View(await myDbContext.ToListAsync());
        }
    }
}
