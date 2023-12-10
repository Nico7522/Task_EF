using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPersonModel = Task_EF.Entities.TaskPerson;

namespace Task_EF.Configs
{
    public class TaskPersonConfig : IEntityTypeConfiguration<TaskPersonModel>
    {
        public void Configure(EntityTypeBuilder<TaskPersonModel> builder)
        {
            builder.HasKey(tp => new { tp.TaskId, tp.PersonId });
            builder.HasOne(t => t.Task).WithMany(t => t.PersonTp).HasForeignKey(t => t.TaskId);
            builder.HasOne(p => p.Person).WithMany(p => p.TaskTp).HasForeignKey(p => p.PersonId);
        }
    }
}
