using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Service
{
    public class LocalizationService
    {
        private readonly DefaultContext _context;
        public LocalizationService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Localization>> GetAll() => new ApiSuccess<IEnumerable<Localization>>(_context.Localizations.ToList());

        public IApiResponse<Localization> Add(Localization Localization)
        {
            if (_context.Localizations.Where(p => p.Name == Localization.Name).Any()) return new ApiFail<Localization>("P02");
            var newClient = _context.Localizations.Add(Localization).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Localization>(newClient);
        }
    }
}
