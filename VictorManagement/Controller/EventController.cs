using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;

namespace KibistaManagement.Controller
{
    public class EventController
    {
        public void insertEvent(String name, String descrip, DateTime startTime, DateTime endTime, String location)
        { 
            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                Event eve = new Event();

                eve.name = name;
                eve.descrip = descrip;
                eve.startTime = startTime;
                eve.endTime = endTime;
                eve.location = location;

                db.Events.InsertOnSubmit(eve);
                db.SubmitChanges();
                
            }
        }
        
        public Event getEvent(String name)
        {
            Event eve = new Event();
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                eve = db.Events.SingleOrDefault(ev => ev.name.Equals(name));
            }

            return eve;
        }

        public void updateEvent(String name, String descrip, DateTime startTime, DateTime endTime, String location)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                Event eve = db.Events.SingleOrDefault(ev => ev.name.Equals(name));

                try
                {
                    if (eve.Equals(null) != true)
                    {
                        eve.name = name;
                        eve.descrip = descrip;
                        eve.startTime = startTime;
                        eve.endTime = endTime;
                        eve.location = location;

                        db.SubmitChanges();
                    }
                }
                catch(NullReferenceException){}
            }
        }
    }
}