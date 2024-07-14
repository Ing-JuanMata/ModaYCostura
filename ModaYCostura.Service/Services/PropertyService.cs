using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;
using Npgsql;

namespace ModaYCostura.Service.Services
{
    public class PropertyService : Service<Property>
    {

        public PropertyService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Property>> GetAll() =>
            new ApiSuccess<IEnumerable<Property>>(_context.Properties.AsQueryable().OrderBy(p => p.Name).ToList());

    }
}
