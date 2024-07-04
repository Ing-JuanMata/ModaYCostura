using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class StatusController : Controller
    {
        private readonly StatusService _statusController;
        public StatusController(DefaultContext context) { _statusController = new StatusService(context); }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Status>> GetAll() => _statusController.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Status> Add([FromBody] Status status) => _statusController.Add(status);
    }
}
