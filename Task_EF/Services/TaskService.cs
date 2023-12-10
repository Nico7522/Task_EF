using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_EF.Domain;
using TaskModel = Task_EF.Entities.Task;
using Task_EF.Repository;

namespace Task_EF.Services
{
    public class TaskService : ITaskRepository
    {
        private readonly DataContext _dc = new DataContext();

        public bool Delete(TaskModel entity)
        {
            throw new NotImplementedException();
        }

        public TaskModel? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskModel> GetAll()
        {
            IEnumerable<TaskModel> tasks = _dc.Tasks.Select(t => new TaskModel(){ TaskId= t.TaskId, Title = t.Title, Description = t.Description, IsCompleted = t.IsCompleted }) ;
            return tasks ;
        }

        public int Insert(TaskModel entity)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, TaskModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
