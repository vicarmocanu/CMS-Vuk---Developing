using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;

namespace KibistaManagement.Controller
{
    public class EventTeamController
    {
        public void createEventTeam(int userId, int eventId)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                Event eve = new Event();
                User use = new User();

                eve = db.Events.Where(e => e.id == eventId).FirstOrDefault();
                use = db.Users.Where(u => u.id == userId).FirstOrDefault();
            }
        }
    }
}