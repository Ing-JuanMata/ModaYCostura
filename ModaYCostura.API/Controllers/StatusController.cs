using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    public class StatusController : Controller
    {
        private readonly StatusService _statusController;
        public StatusController(DefaultContext context) { _statusController = new StatusService(context); }
    }
}
