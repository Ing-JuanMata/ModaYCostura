using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;
using Npgsql;

namespace ModaYCostura.Service.Services
{
    public class UnitService : Service<Unit>
    {
        public UnitService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Unit>> GetAll() =>
            new ApiSuccess<IEnumerable<Unit>>(_context.Units.AsQueryable().OrderBy(u => u.Name).ToList());
    }
}
