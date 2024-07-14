using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Services;
using ModaYCostura.Service.WriteBehaviours;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class LocalizationController : Controller
    {
        private readonly LocalizationService _localizationService;
        private readonly LocalizationWB _localizationWB;
        public LocalizationController(DefaultContext context)
        {
            _localizationService = new LocalizationService(context);
            _localizationWB = new LocalizationWB(context);
        }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Localization>> GetAll() => _localizationService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Localization> Add([FromBody] Localization localization) => _localizationWB.Add(localization);

        [HttpPut, Route("Update")]
        public IApiResponse<Localization> Update([FromBody] Localization localization) => _localizationWB.Update(localization);
    }
}
