using ModaYCostura.Data;
using ModaYCostura.Model.Models;

namespace ModaYCostura.Service
{
    public class ClientService
    {
        private readonly DefaultContext _context;

        public ClientService(DefaultContext context) { _context = context; }

        public IEnumerable<Client> GetClients() { return _context.Clients; }
    }
}