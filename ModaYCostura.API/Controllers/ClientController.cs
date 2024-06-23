using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly ClientService _clientService;
        public ClientController(DefaultContext defaultContext)
        {
            _clientService = new ClientService(defaultContext);
        }

        [HttpGet, Route("GetClients")]
        public IApiResponse<IEnumerable<Client>> GetClients() => _clientService.GetClients();

        [HttpGet, Route("GetClient/{phone}")]
        public IApiResponse<Client> GetClient(string phone) => _clientService.GetClient(phone);

        [HttpGet, Route("ClientExists/{phone}")]
        public IApiResponse<bool> ClientExists(string phone) => _clientService.ClientExists(phone);

        [HttpPost, Route("PostClient")]
        public IApiResponse<Client> PostClient([FromBody] Client client) => _clientService.AddClient(client);

        [HttpPut, Route("PutClient")]
        public IApiResponse<Client> PutClient([FromBody] Client client) => _clientService.UpdateClient(client);
    }
}
