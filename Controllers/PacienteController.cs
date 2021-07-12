using LabCMV.Data;
using LabCMV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabCMV.Controllers
{
    public class PacienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PacienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(int? id)
        {
            Paciente paciente = new Paciente();
            if (id == null)
            {
                return View(paciente);
            }
            else
            {
                paciente = await _db.Paciente.FindAsync(id);
                return View(paciente);
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                if (paciente.Id == 0)       //Cria o registro sim o id == 0
                {
                    await _db.Paciente.AddAsync(paciente);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Create));
                }
                else
                {
                    _db.Paciente.Update(paciente);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Create), new { id = 0});
                }

            }
            return View(paciente);
        }

        //Criamos um API
        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var todos = await _db.Paciente.ToListAsync();
            return Json(new { data = todos });

        }
    }
}
