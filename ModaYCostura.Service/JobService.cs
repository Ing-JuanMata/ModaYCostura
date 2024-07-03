using Microsoft.EntityFrameworkCore;
using ModaYCostura.Data;
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
    }
}
