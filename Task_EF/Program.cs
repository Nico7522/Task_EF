﻿using Task_EF.Domain;
using TaskModel = Task_EF.Entities.Task;

Console.WriteLine("coucou");

#region Ajout personnes

//using (DataContext dc = new DataContext())
//{
//    dc.People.Add(new Task_EF.Entities.Person()
//    {
//        FirstName = "Nicolas",
//        LastName = "D'Addabbo"
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
//        PersonId = 1,
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