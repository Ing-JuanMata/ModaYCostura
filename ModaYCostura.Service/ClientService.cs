using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using Npgsql;

namespace ModaYCostura.Service
{
    public class ClientService
    {
        private readonly DefaultContext _context;

        public ClientService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Client>> GetClients() => new ApiSuccess<IEnumerable<Client>>(_context.Clients.AsQueryable().Where(c => !c.IsAdmin));
        public IApiResponse<Client> GetClient(string phone)
        {
            var response = _context.Clients.Where(e => e.Phone == phone).FirstOrDefault();
            if (response == null) { return new ApiFail<Client>(); }
            return new ApiSuccess<Client>(response);
        }

        public IApiResponse<bool> ClientExists(string phone)
        {
            var response = _context.Clients.Where(e => e.Phone == phone).FirstOrDefault();
            if (response == null) { return new ApiFail<bool>(); }
            return new ApiSuccess<bool>(true);
        }

        public IApiResponse<Client> AddClient(Client client)
        {
            if (_context.Clients.Where(c => c.Phone == client.Phone).Any()) return new ApiFail<Client>("P01");
            var newClient = _context.Clients.Add(client).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Client>(newClient);
        }

        public IApiResponse<Client> UpdateClient(Client client)
        {
            try
            {
                _context.Clients.Update(client);
                _context.SaveChanges();
                return new ApiSuccess<Client>(client);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<Client>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<Client>(ex.Message);
            }
        }
    }
}