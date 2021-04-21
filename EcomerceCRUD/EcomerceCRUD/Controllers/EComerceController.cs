using EcomerceCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceCRUD.Controllers
{
    public class EComerceController : Controller
    {
        private readonly EComerceContext _context;

        public EComerceController(EComerceContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.eComerces.ToListAsync());
        }

        [HttpGet]
        public IActionResult AddOrEdit(int id =0)
        {
            if (id == 0)
                return View(new EComerceModel());
            else
                return View(_context.eComerces.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(EComerceModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ProductId == 0)
                    _context.Add(model);
                else
                    _context.Update(model);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int ? id)
        {
            var ecommerce = await _context.eComerces.FindAsync(id);
            _context.eComerces.Remove(ecommerce);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
