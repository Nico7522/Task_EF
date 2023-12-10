using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_API.Mappers;
using Task_API.Models;
using Task_EF.Domain;
using Task_EF.Repository;

namespace Task_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _task;

        public TaskController(ITaskRepository task)
        {
            _task = task;
        }
        [HttpGet]
        public ActionResult<TaskModel> GetAllTasks() {

            var tasks = _task.GetAll();

            return Ok(tasks.Select(t => t.ToTask()));
        
        }

        [HttpGet("{id}")]
        public ActionResult<TaskModel> GetOneTask(int id)
        {
            var task = _task.Get(id);
            if (task is null)
                return BadRequest();

            return Ok(task.ToTask());
        }
    }
}
