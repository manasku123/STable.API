using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STable.API.Data;
using System.Net.Http.Headers;

namespace STable.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly STableDbContext dbContext;

        public ResultsController(STableDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public Task<IActionResult> GetAll()            
        {
            var results = dbContext.Results.ToList();
            Ok(results);
          

        }
        [HttpGet]
        public Task<IActionResult> GetAll()             
        {
            var results = dbContext.Students.ToList();
            Ok(results);


        }
    }
}
