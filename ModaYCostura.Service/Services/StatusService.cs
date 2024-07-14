using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;
using Npgsql;

namespace ModaYCostura.Service.Services
{
    public class StatusService : Service<Status>
    {
        public StatusService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Status>> GetAll() =>
            new ApiSuccess<IEnumerable<Status>>(_context.Statuses.AsQueryable().OrderBy(s => s.Name).ToList());
    }
}
