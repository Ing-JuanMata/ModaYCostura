using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Service
{
    public class PropertyService
    {
        private readonly DefaultContext _context;
        public PropertyService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Property>> GetAll() => new ApiSuccess<IEnumerable<Property>>(_context.Properties.ToList());

        public IApiResponse<Property> Add(Property property)
        {
            if (_context.Properties.Where(p => p.Name == property.Name).Any()) return new ApiFail<Property>("P02");
            var newProperty = _context.Properties.Add(property).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Property>(newProperty);
        }

        public IApiResponse<Property> Update(Property property)
        {
            try
            {
                _context.Properties.Update(property);
                _context.SaveChanges();
                return new ApiSuccess<Property>(property);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<Property>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<Property>(ex.Message);
            }
        }
    }
}
