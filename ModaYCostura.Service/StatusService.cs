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
    public class StatusService
    {
        private readonly DefaultContext _context;
        public StatusService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Status>> GetAll() => new ApiSuccess<IEnumerable<Status>>(_context.Statuses.ToList());

        public IApiResponse<Status> Add(Status status)
        {
            if (_context.Properties.Where(p => p.Name == status.Name).Any()) return new ApiFail<Status>("P02");
            var newStatus = _context.Statuses.Add(status).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Status>(newStatus);
        }

        public IApiResponse<Status> Update(Status status)
        {
            try
            {
                _context.Statuses.Update(status);
                _context.SaveChanges();
                return new ApiSuccess<Status>(status);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<Status>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<Status>(ex.Message);
            }
        }
    }
}
