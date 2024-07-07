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
    public class UnitService
    {
        private readonly DefaultContext _context;
        public UnitService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Unit>> GetAll() => new ApiSuccess<IEnumerable<Unit>>(_context.Units.ToList());

        public IApiResponse<Unit> Add(Unit unit)
        {
            if (_context.Units.Where(p => p.Name == unit.Name).Any()) return new ApiFail<Unit>("P02");
            var newUnit = _context.Units.Add(unit).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Unit>(newUnit);
        }
    }
}
