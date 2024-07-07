using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class LocalizationController : Controller
    {
        private readonly LocalizationService _localizationService;
        public LocalizationController(DefaultContext context) { _localizationService = new LocalizationService(context); }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Localization>> GetAll() => _localizationService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Localization> Add([FromBody] Localization localization) => _localizationService.Add(localization);
    }
}
