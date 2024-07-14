using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Service.Services;
using ModaYCostura.Service.WriteBehaviours;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class TypeController : Controller
    {
        private readonly TypeService _typeService;
        private readonly TypeWB _typeWB;
        public TypeController(DefaultContext context)
        {
            _typeService = new TypeService(context);
            _typeWB = new TypeWB(context);
        }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Model.Models.Type>> GetAll() => _typeService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Model.Models.Type> Add([FromBody] Model.Models.Type type) => _typeWB.Add(type);
        [HttpPut, Route("Update")]
        public IApiResponse<Model.Models.Type> Update([FromBody] Model.Models.Type type) => _typeWB.Update(type);
    }
}
