using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Services;
using ModaYCostura.Service.WriteBehaviours;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly ClientService _clientService;
        private readonly ClientWB _clientWB;
        public ClientController(DefaultContext defaultContext)
        {
            _clientService = new ClientService(defaultContext);
            _clientWB = new ClientWB(defaultContext);
        }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Client>> GetAll() => _clientService.GetAll();

        [HttpGet, Route("Get/{phone}")]
        public IApiResponse<Client> Get(string phone) => _clientService.Get(phone);

        [HttpGet, Route("Exists/{phone}")]
        public IApiResponse<bool> Exists(string phone) => _clientService.Exists(phone);

        [HttpPost, Route("Add")]
        public IApiResponse<Client> Add([FromBody] Client client) => _clientWB.Add(client);

        [HttpPut, Route("Update")]
        public IApiResponse<Client> Update([FromBody] Client client) => _clientWB.Update(client);
    }
}
