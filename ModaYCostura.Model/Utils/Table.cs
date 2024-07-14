namespace ModaYCostura.Model.Utils
{
    public class Table<T> where T : struct
    {
        public T Id { get; set; }
        public DateTime LastUpdate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
