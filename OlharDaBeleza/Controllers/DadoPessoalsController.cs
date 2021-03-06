﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlharDaBeleza.Models;

namespace OlharDaBeleza.Controllers
{
    public class DadoPessoalsController : Controller
    {
        private readonly OlharDaBelezaContext _context;

        public DadoPessoalsController(OlharDaBelezaContext context)
        {
            _context = context;
        }

        // GET: DadoPessoals
        public async Task<IActionResult> Index()
        {
            return View(await _context.DadoPessoal.ToListAsync());
        }

        // GET: DadoPessoals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadoPessoal = await _context.DadoPessoal
                .FirstOrDefaultAsync(m => m.id == id);
            if (dadoPessoal == null)
            {
                return NotFound();
            }

            return View(dadoPessoal);
        }

        // GET: DadoPessoals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DadoPessoals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Nome,Sexo,Idade,DataDeNascimento,Telefone,Email,Instagram,Facebook,Cpf")] DadoPessoal dadoPessoal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dadoPessoal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dadoPessoal);
        }

        // GET: DadoPessoals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadoPessoal = await _context.DadoPessoal.FindAsync(id);
            if (dadoPessoal == null)
            {
                return NotFound();
            }
            return View(dadoPessoal);
        }

        // POST: DadoPessoals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Nome,Sexo,Idade,DataDeNascimento,Telefone,Email,Instagram,Facebook,Cpf")] DadoPessoal dadoPessoal)
        {
            if (id != dadoPessoal.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dadoPessoal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DadoPessoalExists(dadoPessoal.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dadoPessoal);
        }

        // GET: DadoPessoals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadoPessoal = await _context.DadoPessoal
                .FirstOrDefaultAsync(m => m.id == id);
            if (dadoPessoal == null)
            {
                return NotFound();
            }

            return View(dadoPessoal);
        }

        // POST: DadoPessoals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dadoPessoal = await _context.DadoPessoal.FindAsync(id);
            _context.DadoPessoal.Remove(dadoPessoal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DadoPessoalExists(int id)
        {
            return _context.DadoPessoal.Any(e => e.id == id);
        }
    }
}
