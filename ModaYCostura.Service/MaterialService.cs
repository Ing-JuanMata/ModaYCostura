using Microsoft.EntityFrameworkCore;
using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using Npgsql;

namespace ModaYCostura.Service
{
    public class MaterialService
    {
        private readonly DefaultContext _context;
        public MaterialService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Material>> GetAll() => new ApiSuccess<IEnumerable<Material>>(_context.Materials.Include(m => m.Unit).ToList());

        public IApiResponse<Material> Add(Material material)
        {
            if (_context.Materials.Where(p => p.Name == material.Name).Any()) return new ApiFail<Material>("P02");
            var newClient = _context.Materials.Attach(material).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Material>(newClient);
        }

        public IApiResponse<Material> Update(Material material)
        {
            try
            {
                _context.Materials.Update(material);
                _context.SaveChanges();
                return new ApiSuccess<Material>(material);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<Material>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<Material>(ex.Message);
            }
        }
    }
}
