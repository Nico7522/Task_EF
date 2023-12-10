using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EF.Entities
{
    public class TaskPerson
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
