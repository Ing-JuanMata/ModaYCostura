using ModaYCostura.Model.Utils;

namespace ModaYCostura.Model.Models
{
    public class Job : Table<long>
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public DateTime RequestDate { get; set; }
        public Type Type { get; set; } = new();
        public Status Status { get; set; } = new();
        public Localization Localization { get; set; } = new();
        public Client Client { get; set; } = new();
        public List<JobProperty> Properties { get; set; } = new();
        public List<JobMaterial> Materials { get; set; } = new();
    }
}
