using ModaYCostura.Model.Utils;

namespace ModaYCostura.Model.Models
{
    public class Unit : Table<long>
    {
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
    }
}
