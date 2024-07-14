using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Services;
using ModaYCostura.Service.WriteBehaviours;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class MaterialController : Controller
    {
        private readonly MaterialService _materialService;
        private readonly MaterialWB _materialWB;
        public MaterialController(DefaultContext context)
        {
            _materialService = new MaterialService(context);
            _materialWB = new MaterialWB(context);
        }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Material>> GetAll() => _materialService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Material> Add([FromBody] Material material) => _materialWB.Add(material);

        [HttpPut, Route("Update")]
        public IApiResponse<Material> Update([FromBody] Material material) => _materialWB.Update(material);
    }
}
