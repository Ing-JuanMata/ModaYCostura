using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.Services
{
    public class JobService : Service<Job>
    {
        public JobService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Job>> GetAll() => new ApiSuccess<IEnumerable<Job>>(_context.Jobs.ToList());
    }
}
