using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EF.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public List<TaskPerson> PersonTp { get; set; }
    }
}
