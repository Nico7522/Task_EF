using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskModel =  Task_EF.Entities.Task;


namespace Task_EF.Configs
{
    public class TaskConfig : IEntityTypeConfiguration<TaskModel>
    {
        public void Configure(EntityTypeBuilder<TaskModel> builder)
        {
            builder.HasKey(t => t.TaskId);
            builder.Property(t => t.TaskId).ValueGeneratedOnAdd();
            builder.Property(t => t.Title).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(300).IsRequired();
            builder.Property(t => t.IsCompleted).HasDefaultValue(false);
        }
    }
}
