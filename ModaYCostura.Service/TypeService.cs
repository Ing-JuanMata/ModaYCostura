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
    public class TypeService
    {
        private readonly DefaultContext _context;
        public TypeService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Model.Models.Type>> GetAll() => new ApiSuccess<IEnumerable<Model.Models.Type>>(_context.Types.ToList());

        public IApiResponse<Model.Models.Type> Add(Model.Models.Type type)
        {
            if (_context.Types.Where(p => p.Name == type.Name).Any()) return new ApiFail<Model.Models.Type>("P02");
            var newType = _context.Types.Add(type).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Model.Models.Type>(newType);
        }
    }
}
