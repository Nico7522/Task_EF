using Task_API.Models;
using Task_EF.Models;
using TaskEntity = Task_EF.Entities.Task;

namespace Task_API.Mappers
{
    internal static class Mappers
    {

        internal static TaskDTO ToTask(this TaskEntity task)
        {
            return new TaskDTO
            {
                TaskId = task.TaskId,
                Title = task.Title,
                Description = task.Description,
                IsCompleted = task.IsCompleted,
            };
        }

        internal static TaskWithPersonDTO ToTaskWithPerson(this TaskWithPerson task)
        {
            return new TaskWithPersonDTO
            {
                TaskId = task.TaskId,
                Title = task.Title,
                Description = task.Description,
                IsCompleted = task.IsCompleted,
                People = task.People.Select(p => new PersonDTO { PersonId = p.PersonId, FirstName = p.FirstName, LastName = p.LastName }).ToList(),
            };
        }
    }
}
