using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    public class LocalizationController : Controller
    {
        private readonly LocalizationService _localizationService;
        public LocalizationController(DefaultContext context) { _localizationService = new LocalizationService(context); }
    }
}
