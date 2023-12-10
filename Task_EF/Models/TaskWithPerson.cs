using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_EF.Entities;

namespace Task_EF.Models
{
    public class TaskWithPerson
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public List<Person> People { get; set; }
    }
}
