using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Model.Models
{
    public class Client
    {

        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required, MinLength(10), MaxLength(15)]
        public string Phone { get; set; } = string.Empty;
        public bool IsAdmin { get; set; } = false;
    }
}
