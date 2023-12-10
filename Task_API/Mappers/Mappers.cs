using Task_API.Models;
using TaskEntity = Task_EF.Entities.Task;

namespace Task_API.Mappers
{
    internal static class Mappers
    {

        internal static TaskModel ToTask(this TaskEntity task)
        {
            return new TaskModel
            {
                TaskId = task.TaskId,
                Title = task.Title,
                Description = task.Description,
                IsCompleted = task.IsCompleted,
            };
        }
    }
}
