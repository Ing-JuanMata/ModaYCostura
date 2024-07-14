using System.ComponentModel.DataAnnotations;

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
