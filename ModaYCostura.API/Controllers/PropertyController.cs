using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    public class PropertyController : Controller
    {
        private readonly PropertyService _propertyService;
        public PropertyController(DefaultContext context) { _propertyService = new PropertyService(context); }
    }
}
