using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class UnitController : Controller
    {
        private readonly UnitService _unitService;
        public UnitController(DefaultContext context) { _unitService = new UnitService(context); }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Unit>> GetAll() => _unitService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Unit> Add([FromBody] Unit unit) => _unitService.Add(unit);
    }
}
