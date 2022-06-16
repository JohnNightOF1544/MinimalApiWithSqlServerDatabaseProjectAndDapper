using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; } = null!;
        [Required]
        public string Middlename { get; set; } = null!;
        [Required]
        public string Lastname { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        [Required]
        public string Address { get; set; } = null!;

        public bool Active { get; set; } 
    }
}
