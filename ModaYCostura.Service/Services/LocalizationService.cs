using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.Services
{
    public class LocalizationService : Service<Localization>
    {

        public LocalizationService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Localization>> GetAll() =>
            new ApiSuccess<IEnumerable<Localization>>(_context.Localizations.AsQueryable().OrderBy(l => l.Name).ToList());
    }
}
