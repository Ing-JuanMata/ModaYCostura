using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Model.Models
{
    public class Job
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public Type Type { get; set; } = new();
        public Status Status { get; set; } = new();
        public Localization Localization { get; set; } = new();
        public Client Client { get; set; } = new();
        public List<Property> Properties { get; set; } = new();
        public List<Material> Materials { get; set; } = new();
    }
}
