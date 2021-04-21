using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceCRUD.Models
{
    public class EComerceModel
    {
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
    }
}
