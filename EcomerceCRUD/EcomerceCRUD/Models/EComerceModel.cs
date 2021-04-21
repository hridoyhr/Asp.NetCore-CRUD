using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceCRUD.Models
{
    public class EComerceModel
    {
        private readonly EComerceContext _context;

        public EComerceModel(EComerceContext context)
        {
            _context = context;
        }

        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Enter you Product Name")]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage ="Quantity")]
        [Display(Name ="Quantity")]
        public double Quantity { get; set; }

        [Required(ErrorMessage ="Price")]
        [Display(Name ="Price")]
        public double Price { get; set; }

        [Required(ErrorMessage ="Company")]
        [Display(Name = "Company")]
        public string Company { get; set; }

        internal EComerceModel FindData(int id)
        {
            return _context.eComerces.Find(id);
        }

        public async Task<IList<EComerceModel>> ListOfData()
        {
            var data =  await _context.eComerces.ToListAsync();
            return data;
        }

        internal void Add(EComerceModel model)
        {
            _context.Add(model);
        }

        internal async Task save()
        {
            await _context.SaveChangesAsync();
        }

        internal void update(EComerceModel model)
        {
            _context.Update(model);
        }
    }
}
