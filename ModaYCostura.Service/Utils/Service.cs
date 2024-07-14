using ModaYCostura.Data;

namespace ModaYCostura.Service.Utils
{
    public class Service<T> where T : class
    {
        protected readonly DefaultContext _context;
        public Service(DefaultContext context) { _context = context; }
    }
}
