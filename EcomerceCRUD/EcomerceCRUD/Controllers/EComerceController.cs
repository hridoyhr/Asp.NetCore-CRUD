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
            var model = new EComerceModel(_context);
            var data = model.ListOfData();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddOrEdit(int id =0)
        {
            var model = new EComerceModel(_context);
            if (id == 0)
                return View(model);
            else
            {
                var existingData = model.FindData(id);
                return View(existingData);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(EComerceModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ProductId == 0)
                    model.Add(model);
                else
                    model.update(model);

                await model.save();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            var model = new EComerceModel(_context);
            var ecommerce = model.FindData(id.GetValueOrDefault());
            _context.eComerces.Remove(ecommerce);

            await model.save();
            return RedirectToAction(nameof(Index));
        }
    }
}
