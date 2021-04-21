using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCRUD.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Enter Your Email")]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Enter Your Phone")]
        [DisplayName("Phone Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Enter Your Address")]
        [DisplayName("Address")]
        public string Address { get; set; }
    }
}
