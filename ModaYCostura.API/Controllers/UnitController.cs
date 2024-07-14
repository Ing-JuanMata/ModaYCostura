using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Services;
using ModaYCostura.Service.WriteBehaviours;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class UnitController : Controller
    {
        private readonly UnitService _unitService;
        private readonly UnitWB _unitWB;
        public UnitController(DefaultContext context)
        {
            _unitService = new UnitService(context);
            _unitWB = new UnitWB(context);
        }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Unit>> GetAll() => _unitService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Unit> Add([FromBody] Unit unit) => _unitWB.Add(unit);
        [HttpPut, Route("Update")]
        public IApiResponse<Unit> Update([FromBody] Unit unit) => _unitWB.Update(unit);
    }
}
