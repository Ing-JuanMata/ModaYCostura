using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Services;
using ModaYCostura.Service.WriteBehaviours;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly PropertyService _propertyService;
        private readonly PropertyWB _propertyWB;
        public PropertyController(DefaultContext context)
        {
            _propertyService = new PropertyService(context);
            _propertyWB = new PropertyWB(context);
        }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Property>> GetAll() => _propertyService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Property> Add([FromBody] Property property) => _propertyWB.Add(property);

        [HttpPut, Route("Update")]
        public IApiResponse<Property> Update([FromBody] Property property) => _propertyWB.Update(property);
    }
}
