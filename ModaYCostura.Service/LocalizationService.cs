using ModaYCostura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Service
{
    public class LocalizationService
    {
        private readonly DefaultContext _context;
        public LocalizationService(DefaultContext context) { _context = context; }
    }
}
