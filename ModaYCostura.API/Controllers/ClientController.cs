using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly DefaultContext _context;
        private readonly ClientService _clientService;
        public ClientController(DefaultContext defaultContext)
        {
            _context = defaultContext;
            _clientService = new ClientService(defaultContext);
        }

        [HttpGet, Route("GetClients")]
        public IEnumerable<Client> GetClients()
        {
            return _clientService.GetClients();
        }
    }
}
