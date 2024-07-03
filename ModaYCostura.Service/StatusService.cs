using ModaYCostura.Data;
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
    }
}
