using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModel = Task_EF.Entities.Task;

namespace Task_EF.Repository
{
    public interface ITaskRepository : ICrudRepository<int, TaskModel>
    {
        IEnumerable<TaskModel> GetAllWithPerson();
       
    }
}
