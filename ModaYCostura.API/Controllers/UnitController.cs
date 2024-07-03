using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    public class UnitController : Controller
    {
        private readonly UnitService _unitService;
        public UnitController(DefaultContext context) { _unitService = new UnitService(context); }
    }
}
