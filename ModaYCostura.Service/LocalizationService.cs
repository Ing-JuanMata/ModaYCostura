using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using Npgsql;
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

        public IApiResponse<Localization> Update(Localization localization)
        {
            try
            {
                _context.Localizations.Update(localization);
                _context.SaveChanges();
                return new ApiSuccess<Localization>(localization);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<Localization>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<Localization>(ex.Message);
            }
        }
    }
}
