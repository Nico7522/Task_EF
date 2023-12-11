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
        public ActionResult<TaskDTO> GetAllTasks() {

            var tasks = _task.GetAll();

            return Ok(tasks.Select(t => t.ToTask()));
        
        }

        [HttpGet("withperson")]
        public ActionResult<TaskWithPersonDTO> GetAllWithPerson()
        {
            var tasks = _task.GetAllWithPerson();
            return Ok(tasks.Select(t => t.ToTaskWithPerson()).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<TaskDTO> GetOneTask(int id)
        {
            var task = _task.Get(id);
            if (task is null)
                return BadRequest();

            return Ok(task.ToTask());
        }
    }
}
