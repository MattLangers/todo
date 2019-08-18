using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Controllers
{
    using Services;

    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IGetTaskOrchestrator getTaskOrchestrator;

        public TaskController(
            IGetTaskOrchestrator getTaskOrchestrator)
        {
            this.getTaskOrchestrator = getTaskOrchestrator;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Task>> Get()
        {
            return this.Ok(this.getTaskOrchestrator.GetTasks());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
