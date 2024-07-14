using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.Services
{
    public class ClientService : Service<Client>
    {
        public ClientService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Client>> GetAll() => new ApiSuccess<IEnumerable<Client>>(_context.Clients.AsQueryable().Where(c => !c.IsAdmin).OrderBy(c => c.Phone));
        public IApiResponse<Client> Get(string phone)
        {
            var response = _context.Clients.Where(e => e.Phone == phone).FirstOrDefault();
            if (response == null) { return new ApiFail<Client>(); }
            return new ApiSuccess<Client>(response);
        }
        public IApiResponse<bool> Exists(string phone)
        {
            var response = _context.Clients.Where(e => e.Phone == phone).FirstOrDefault();
            if (response == null) { return new ApiFail<bool>(); }
            return new ApiSuccess<bool>(true);
        }
    }
}
