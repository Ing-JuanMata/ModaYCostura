namespace ModaYCostura.Model.Interfaces
{
    public interface IApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public List<string> Messages { get; set; }
    }
}
