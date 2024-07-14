using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Service.Utils;
using Npgsql;

namespace ModaYCostura.Service.Services
{
    public class TypeService : Service<Model.Models.Type>
    {
        public TypeService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Model.Models.Type>> GetAll() =>
            new ApiSuccess<IEnumerable<Model.Models.Type>>(_context.Types.AsQueryable().OrderBy(t => t.Name).ToList());
    }
}
