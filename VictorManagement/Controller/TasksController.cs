using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;
using System.Collections;

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

        // #delete
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

        public List<Task> getEventTasks(int eventId)
        {
            List<Task> eventTasks = new List<Task>();

            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.Tasks.Where(tsk => tsk.eventId == eventId).ToList();

                eventTasks = query;
            }

            return eventTasks;
        }

        public List<TaskStringConversion> getWantedTasks(int eventId)
        {
            List<TaskStringConversion> stringTaskList = new List<TaskStringConversion>();

            List<Task> eventTasks = new List<Task>();
            eventTasks = getEventTasks(eventId);

            foreach (Task tsk in eventTasks)
            {
                TaskStringConversion taskInString = new TaskStringConversion();

                taskInString.Id = Convert.ToString(tsk.id);
                taskInString.Name = Convert.ToString(tsk.name);
                taskInString.EventId = Convert.ToString(tsk.eventId);
                taskInString.Descrip = Convert.ToString(tsk.descrip);

                stringTaskList.Add(taskInString);
            }

            return stringTaskList;
        }

        public Dictionary<int, string> getEventTasks_Dictionary(int eventId)
        {
            Dictionary<int, string> eventTasks = new Dictionary<int, string>();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.Tasks.Where(tsk => tsk.eventId == eventId).ToList();
                List<Task> tasks = new List<Task>();
                tasks = query;

                foreach(Task task in tasks)
                {
                    eventTasks.Add(task.id, task.name);
                }
            }

            return eventTasks;
        }
    }
}