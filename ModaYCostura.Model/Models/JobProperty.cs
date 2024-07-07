using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Model.Models
{
    public class JobProperty
    {
        [Key]
        public Job Job { get; set; } = new();
        [Key]
        public Property Property { get; set; } = new();
        public string Value { get; set; } = string.Empty;
    }
}
