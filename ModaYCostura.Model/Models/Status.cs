using ModaYCostura.Model.Utils;

namespace ModaYCostura.Model.Models
{
    public class Status : Table<long>
    {
        public string Name { get; set; } = string.Empty;
    }
}
