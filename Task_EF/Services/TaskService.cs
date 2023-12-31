﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_EF.Domain;
using TaskModel = Task_EF.Entities.Task;
using Task_EF.Repository;
using Task_EF.Entities;
using Task_EF.Models;

namespace Task_EF.Services
{
    public class TaskService : ITaskRepository
    {
        private readonly DataContext _dc = new DataContext();

        public IEnumerable<TaskModel> GetAll()
        {
            IEnumerable<TaskModel> tasks = _dc.Tasks.Select(t => new TaskModel(){ TaskId= t.TaskId, Title = t.Title, Description = t.Description, IsCompleted = t.IsCompleted, PersonTp = t.PersonTp }) ;
            return tasks ;
        }
        public TaskModel? Get(int id)
        {
            TaskModel? task = _dc.Tasks.Where(t => t.TaskId == id).SingleOrDefault();
            if (task == null)
                return null;

            return task;
        }

        public IEnumerable<TaskWithPerson> GetAllWithPerson()
        {
           
           IEnumerable<TaskWithPerson> tasksWithPeople = _dc.TaskPerson
                .Join(_dc.People, tp => tp.PersonId, p => p.PersonId, (tp, p) => new { TaskPerson = tp, Person = p })
                .Join(_dc.Tasks, tp => tp.TaskPerson.TaskId, t => t.TaskId, (tp, t) => new { Tache = t, Personne = tp })
                .GroupBy(x => x.Tache)
                .AsEnumerable()
                .Select(t => new TaskWithPerson()
                {
                    TaskId = t.Key.TaskId,
                    Title = t.Key.Title,
                    Description = t.Key.Description,
                    IsCompleted = t.Key.IsCompleted,
                    People = t.Key.PersonTp.Select(x => x.Person).ToList(),
                });
            return tasksWithPeople;
        }

        public int Insert(TaskModel entity)
        {
           var createdTask = _dc.Add(entity);
            _dc.SaveChanges();
            int id = createdTask.Entity.TaskId;
            if (id <= 0) return id;

            return id;
        }

        public int Update(int id, TaskModel entity)
        {
            throw new NotImplementedException();
        }


        public bool Delete(TaskModel entity)
        {
            throw new NotImplementedException();
        }

    }
}
