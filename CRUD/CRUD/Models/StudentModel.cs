using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Phone { get; set; }
         
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
    }
}
