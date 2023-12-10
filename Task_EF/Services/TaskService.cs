using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_EF.Domain;
using TaskModel = Task_EF.Entities.Task;
using Task_EF.Repository;
using Task_EF.Entities;

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
            TaskModel? task = _dc.Tasks.Where(t => t.TaskId == id).SingleOrDefault();
            if (task == null)
                return null;

            return task;
        }

        public IEnumerable<TaskModel> GetAll()
        {
            IEnumerable<TaskModel> tasks = _dc.Tasks.Select(t => new TaskModel(){ TaskId= t.TaskId, Title = t.Title, Description = t.Description, IsCompleted = t.IsCompleted, PersonTp = t.PersonTp }) ;
            return tasks ;
        }

        public IEnumerable<TaskModel> GetAllWithPerson()
        {
            // TO FIX
            //IEnumerable<TaskModel> tasks = (IEnumerable<TaskModel>)_dc.TaskPerson.Join(_dc.People, tp => tp.PersonId, p => p.PersonId, (tp, p) => new { Tache = tp, Personne = p })
            //                                             .Join(_dc.Tasks, p => p.Tache.TaskId, t => t.TaskId, (p, t) => new TaskModel{ TaskId = t.TaskId, PersonTp = t.PersonTp })
            //                                             .GroupBy(x => x.TaskId);


            //return tasks ;
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
