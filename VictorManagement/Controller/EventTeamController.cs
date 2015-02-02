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

        public List<UserStringConversion> getEventTeamMembers(int eventId)
        {
            List<UserStringConversion> teamMembers = new List<UserStringConversion>();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                List<EventTeam> eventTeam = new List<EventTeam>(); 
                var query = db.EventTeams.Where(et => et.eventId == eventId).ToList();
                eventTeam = query;

                foreach(EventTeam evt in eventTeam)
                {
                    int userId = evt.userId;
                    User user = new User();
                    user = db.Users.SingleOrDefault(usr => usr.id == userId);

                    UserStringConversion stringUser = new UserStringConversion();

                    stringUser.Id = Convert.ToString(user.id);
                    stringUser.Name = Convert.ToString(user.name);
                    stringUser.Pass = Convert.ToString(user.pass);
                    stringUser.Email = Convert.ToString(user.email);
                    stringUser.Type = Convert.ToString(user.types);
                    stringUser.PhoneNr = Convert.ToString(user.phoneNr);

                    teamMembers.Add(stringUser);
                }
            }
            return teamMembers;
        }
    }
}