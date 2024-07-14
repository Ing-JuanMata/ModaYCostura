using ModaYCostura.Model.Utils;

namespace ModaYCostura.Model.Models
{
    public class Note : Table<long>
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public Job Job { get; set; } = new();
    }
}
