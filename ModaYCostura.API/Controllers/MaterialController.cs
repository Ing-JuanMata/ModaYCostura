using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    public class MaterialController : Controller
    {
        private readonly MaterialService _materialService;
        public MaterialController(DefaultContext context) { _materialService = new MaterialService(context); }
    }
}
