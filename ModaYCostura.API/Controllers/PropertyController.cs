using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly PropertyService _propertyService;
        public PropertyController(DefaultContext context) { _propertyService = new PropertyService(context); }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Property>> GetAll() => _propertyService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Property> Add([FromBody] Property property) => _propertyService.Add(property);
    }
}
