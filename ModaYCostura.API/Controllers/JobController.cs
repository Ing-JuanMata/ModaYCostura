using Microsoft.AspNetCore.Mvc;
using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service;

namespace ModaYCostura.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class JobController : Controller
    {
        private readonly JobService _jobService;
        public JobController(DefaultContext context) { _jobService = new JobService(context); }

        [HttpGet, Route("GetAll")]
        public IApiResponse<IEnumerable<Job>> GetAll() => _jobService.GetAll();

        [HttpPost, Route("Add")]
        public IApiResponse<Job> Add([FromBody] Job job) => _jobService.Add(job);
    }
}
