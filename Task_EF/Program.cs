using Task_EF.Domain;
using Task_EF.Repository;
using Task_EF.Services;
using TaskModel = Task_EF.Entities.Task;

Console.WriteLine("coucou");

#region Ajout personnes

//using (DataContext dc = new DataContext())
//{
//    dc.People.Add(new Task_EF.Entities.Person()
//    {
//        FirstName = "John",
//        LastName = "Doe"
//    });

//    dc.SaveChanges();
//}

#endregion

#region Ajout Tâches

//using (DataContext dc = new DataContext())
//{
//    dc.Tasks.Add(new TaskModel()
//    {
//        Title = "Nettoyer la maison",
//        Description = "Nettoyer la cuisine, le salon et la salle de bain"
//    });

//    int EntriesNumber = dc.SaveChanges();

//    if (EntriesNumber > 0)
//        Console.WriteLine("OK");
//}

#endregion

#region Liaison tâche / personne

//using (DataContext dc = new DataContext())
//{
//    dc.TaskPerson.Add(new Task_EF.Entities.TaskPerson()
//    {
//        TaskId = 2,
//        PersonId = 2,
//    });

//    int EntriesNumber = dc.SaveChanges();

//    if (EntriesNumber > 0)
//        Console.WriteLine("OK");

//}

#endregion

#region Select des personnes avec leurs tâches
//using (DataContext dc = new DataContext())
//{
//    var list = dc.TaskPerson.Join(dc.People, tp => tp.PersonId, p => p.PersonId, (tp, p) => new { Tache = tp, Personne = p})
//                            .Join(dc.Tasks, p => p.Tache.TaskId, t => t.TaskId, (p, t) => new { Task = t, Person = p }).GroupBy(x => x.Person.Personne);

//    foreach (var tp in list)
//    {
//        Console.WriteLine(tp.Key.FirstName);
//        foreach (var item in tp)
//        {
//            Console.WriteLine(item.Task.Title);
//        }
//    }
//}

#endregion

#region Select des tâches avec les personnes associées
//using (DataContext dc = new DataContext())
//{
//    var list = dc.TaskPerson.Join(dc.People, tp => tp.PersonId, p => p.PersonId, (tp, p) => new { Tache = tp, Personne = p })
//                            .Join(dc.Tasks, p => p.Tache.TaskId, t => t.TaskId, (p, t) => new { Task = t, Person = p }).GroupBy(x => x.Task);

//    foreach (var tp in list)
//    {
//        Console.WriteLine(tp.Key.Title);
//        foreach (var item in tp)
//        {
//            Console.WriteLine(item.Person.Personne.FirstName);
//        }
//    }
//}

#endregion

//DataContext dc = new DataContext();
ITaskRepository _taskRepo = new TaskService();
#region GetAll avec services
//var l = _taskRepo.GetAll();

//foreach (var item in l)
//{
//    Console.WriteLine(item.Description);

//}

#endregion

#region Get avec services

//var task = _taskRepo.Get(1);

//if (task != null)
//{
//    Console.WriteLine(task.Description);
//}

#endregion

#region GetWithPerson avec service

var list = _taskRepo.GetAllWithPerson();
foreach (var task in list)
{
    Console.WriteLine(task.Description);
    if (task.People.Count() > 0)
    {
        foreach (var person in task.People)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
#endregion

