using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Model.Models
{
    public class JobMaterial
    {
        [Key]
        public Material Material { get; set; } = new();
        [Key]
        public Job Job { get; set; } = new();
        public double Units { get; set; }
        public double UnitPrice { get; set; }
    }
}
