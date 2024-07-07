using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class TypeController : Controller
    {
        private readonly TypeService _typeService;
        public TypeController(DefaultContext context) { _typeService = new TypeService(context); }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Model.Models.Type>> GetAll() => _typeService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Model.Models.Type> Add([FromBody] Model.Models.Type type) => _typeService.Add(type);
    }
}
