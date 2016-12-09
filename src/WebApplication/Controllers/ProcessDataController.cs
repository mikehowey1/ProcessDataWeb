using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Contracts;

namespace WebApplication.Controllers
{
    /// <summary>
    /// Process Data Controller
    /// </summary>
    [Route("api/v1/[controller]")]
    public class ProcessDataController : Controller
    {
       
        /// <summary>
        /// Get Value
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ProcessTest> Get()
        {
            return Startup.data.Values.ToArray();
        }

        // POST api/v1/values
        [HttpPost]
        public void Post([FromBody] ProcessTest request)
        {
            Startup.data.Add(Guid.NewGuid().ToString(), request);
        }
    }
}
