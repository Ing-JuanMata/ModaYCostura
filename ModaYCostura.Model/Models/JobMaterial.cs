using System.ComponentModel.DataAnnotations;

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
