using ModaYCostura.Model.Utils;

namespace ModaYCostura.Model.Models
{
    public class Property : Table<long>
    {
        public string Name { get; set; } = string.Empty;
    }
}
