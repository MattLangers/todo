using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using Models.InputModels;
    using Models.OutputModels;
    using Services;

    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly ITasksOrchestrator _tasksOrchestrator;

        public TaskController(
            ILogger<TaskController> logger,
            ITasksOrchestrator tasksOrchestrator)
        {
            this.logger = logger;
            this._tasksOrchestrator = tasksOrchestrator;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskInputModel>> Get()
        {
            return this.Ok(this._tasksOrchestrator.GetTasks());
        }

        [HttpGet("{id}")]
        public ActionResult<TaskOutputModel> Get(int id)
        {
            this.logger.LogInformation($"Request task: {id}");
            return this.Ok(this._tasksOrchestrator.GetTask(id));
        }

        [HttpPost]
        public async Task<ActionResult<TaskOutputModel>> Post([FromBody] TaskInputModel task)
        {
            return this.Ok(await this._tasksOrchestrator.PersistTask(task));
        }
    }
}
