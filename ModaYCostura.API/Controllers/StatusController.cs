using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Services;
using ModaYCostura.Service.WriteBehaviours;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class StatusController : Controller
    {
        private readonly StatusService _statusService;
        private readonly StatusWB _statusWB;
        public StatusController(DefaultContext context)
        {
            _statusService = new StatusService(context);
            _statusWB = new StatusWB(context);
        }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Status>> GetAll() => _statusService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Status> Add([FromBody] Status status) => _statusWB.Add(status);
        [HttpPut, Route("Update")]
        public IApiResponse<Status> Update([FromBody] Status status) => _statusWB.Update(status);
    }
}
