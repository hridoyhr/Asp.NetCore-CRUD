using CRUD.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class AccountController : Controller
    {
        private readonly StudentInfoContext _context;

        public AccountController(StudentInfoContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Insert()
        {
            return View(await _context.StudentModels.ToListAsync());
        }
        
       
    }
}
