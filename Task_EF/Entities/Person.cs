using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EF.Entities
{
    public class Person
    {
        #nullable disable
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<TaskPerson> TaskTp { get; set; }
    }
}
