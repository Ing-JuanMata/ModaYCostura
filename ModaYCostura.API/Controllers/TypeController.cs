using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    public class TypeController : Controller
    {
        private readonly TypeService _typeService;
        public TypeController(DefaultContext context) { _typeService = new TypeService(context); }
    }
}
