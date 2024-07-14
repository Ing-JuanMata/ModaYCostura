using ModaYCostura.Model.Utils;

namespace ModaYCostura.Model.Models
{
    public class Material : Table<long>
    {
        public string Name { get; set; } = string.Empty;
        public Unit Unit { get; set; } = new();
    }
}
