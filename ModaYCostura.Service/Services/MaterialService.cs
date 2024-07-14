using Microsoft.EntityFrameworkCore;
using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;
using Npgsql;

namespace ModaYCostura.Service.Services
{
    public class MaterialService : Service<Material>
    {
        public MaterialService(DefaultContext context) : base(context) { }

        public IApiResponse<IEnumerable<Material>> GetAll() =>
            new ApiSuccess<IEnumerable<Material>>(_context.Materials.Include(m => m.Unit).OrderBy(m => m.Name).ToList());

    }
}
