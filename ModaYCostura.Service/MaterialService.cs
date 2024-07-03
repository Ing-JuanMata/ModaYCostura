using ModaYCostura.Data;
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
    }
}
