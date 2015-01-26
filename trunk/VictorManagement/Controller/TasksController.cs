using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;

namespace KibistaManagement.Controller
{
    public class TasksController
    {
        // #create
        public void createTask(int eventId, String name, String descrip)
        {
            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                Event baseEvent = new Event();
                Task task = new Task();

                baseEvent = db.Events.Where(e => e.id == eventId).FirstOrDefault();
                if(baseEvent != null)
                {
                    task.eventId = eventId;
                    task.name = name;
                    task.descrip = descrip;

                    db.Tasks.InsertOnSubmit(task);
                    db.SubmitChanges();
                }
            }
        }

        // #read
        public Task getTaskById(int id)
        {
            Task task = new Task();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                task = db.Tasks.SingleOrDefault(tsk => tsk.id == id);
            }

            return task;
        }

        // #update
        public void updateTaskById(int id, int eventId, String name, String descrip)
        {
            Task task = new Task();
            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                task = db.Tasks.SingleOrDefault(tsk => tsk.id == id);

                try
                {
                    if (task != null)
                    {
                        task.eventId = eventId;
                        task.name = name;
                        task.descrip = descrip;

                        db.SubmitChanges();
                    }
                }
                catch (NullReferenceException) { }
            }
        }

        // #nodelete
        public void deleteTaskById(int id)
        {
            Task task = new Task();
            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                try
                {
                    task = db.Tasks.SingleOrDefault(tsk => tsk.id == id);
                    if (task != null)
                    {
                        db.Tasks.DeleteOnSubmit(task);
                        db.SubmitChanges();
                    }
                }
                catch (NullReferenceException) { }              
            }
        }

    }
}