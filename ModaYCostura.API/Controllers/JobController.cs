using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class JobController : Controller
    {
        private readonly JobService _jobService;
        public JobController(DefaultContext context) { _jobService = new JobService(context); }
    }
}
