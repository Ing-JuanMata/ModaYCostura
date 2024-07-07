using Microsoft.EntityFrameworkCore;
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
    public class JobService
    {
        private readonly DefaultContext _context;
        public JobService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Job>> GetAll() => new ApiSuccess<IEnumerable<Job>>(_context.Jobs.ToList());

        public IApiResponse<Job> Add(Job Job)
        {
            if (_context.Jobs.Where(p => p.Name == Job.Name).Any()) return new ApiFail<Job>("P02");
            var newClient = _context.Jobs.Add(Job).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Job>(newClient);
        }
    }
}
