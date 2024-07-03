using ModaYCostura.Data;
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
    }
}
