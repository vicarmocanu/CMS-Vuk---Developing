using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;
using System.Collections;

namespace KibistaManagement.Controller
{
    public class EventController
    {
        public void insertEvent(String name, String descrip, DateTime startTime, DateTime endTime, String location)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
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
                catch (NullReferenceException) { }
            }
        }

        public Dictionary<int, string> getEventsFor3Days()
        {
            Dictionary<int, string>  events = new Dictionary<int, string>();

            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.Events.Where(ev => ev.endTime >= DateTime.Now.AddHours(-24) && ev.endTime <= DateTime.Now.AddHours(+24)).ToList();
                List<Event> eventsList = new List<Event>();
                eventsList = query;

                foreach(Event ev in eventsList)
                {
                    events.Add(ev.id, ev.name);
                }                
            }

            return events;
            
        }

        public List<Event> getWeekEvents(DateTime startTime)
        {
            List<Event> weekEvents = new List<Event>();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.Events.Where(ev => ev.startTime >= DateTime.Now && ev.startTime <= DateTime.Now.AddDays(+7)).ToList();

                weekEvents = query;

            }

            return weekEvents;
        }

        public List<EventStringConversion> repeaterListGeneration()
        {
            List<EventStringConversion> stringEventsList = new List<EventStringConversion>();

            List<Event> weekEvents = new List<Event>();
            weekEvents = getWeekEvents(DateTime.Now);

            foreach(Event ev in weekEvents)
            {
                EventStringConversion eventInString = new EventStringConversion();

                eventInString.ID = Convert.ToString(ev.id);
                eventInString.Name = Convert.ToString(ev.name);
                eventInString.StartTime = Convert.ToString(ev.startTime);
                eventInString.EndTime = Convert.ToString(ev.endTime);
                eventInString.Descrip = Convert.ToString(ev.descrip);
                eventInString.Location = Convert.ToString(ev.location);

                stringEventsList.Add(eventInString);
            }

            return stringEventsList;
        }
    }
}