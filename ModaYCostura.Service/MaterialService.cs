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
    public class MaterialService
    {
        private readonly DefaultContext _context;
        public MaterialService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Material>> GetAll() => new ApiSuccess<IEnumerable<Material>>(_context.Materials.ToList());

        public IApiResponse<Material> Add(Material material)
        {
            if (_context.Materials.Where(p => p.Name == material.Name).Any()) return new ApiFail<Material>("P02");
            var newClient = _context.Materials.Add(material).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Material>(newClient);
        }
    }
}
