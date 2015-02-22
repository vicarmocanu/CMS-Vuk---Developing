using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;

namespace KibistaManagement.Controller
{
    public class UserChkController
    {
        // #create
        public void createUserChk(int eventId, int taskId, int userId, DateTime userTime, String userDescription, Boolean userChk)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                UserChk chkUsr = new UserChk();

                chkUsr.eventId = eventId;
                chkUsr.taskId = taskId;
                chkUsr.userId = userId;
                chkUsr.userTime = userTime;
                chkUsr.userDescription = userDescription;
                chkUsr.userchk1 = userChk;

                db.UserChks.InsertOnSubmit(chkUsr);
                db.SubmitChanges();

            }
        }

        //get the user check for a particular event and task
        //the user type is specified
        public List<UserCheckStringConversion> getUserChecks(int eventId, int taskId, String userType)
        {
            List<UserCheckStringConversion> customerChecks = new List<UserCheckStringConversion>();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.UserChks.Where(chk => chk.eventId == eventId && chk.taskId == taskId).ToList();
                List<UserChk> allChecks = new List<UserChk>();
                allChecks = query;

                foreach (UserChk usrChk in allChecks)
                {
                    int userId = 0;
                    userId = usrChk.userId;
                    User user = new User();
                    user = db.Users.SingleOrDefault(usr => usr.id == userId);

                    if (user != null)
                    {
                        String type = "";
                        type = Convert.ToString(user.types);

                        if (type.Equals(userType) == true)
                        {
                            UserCheckStringConversion userCheckString = new UserCheckStringConversion();

                            Task task = new Task();
                            task = db.Tasks.SingleOrDefault(tsk => tsk.id == taskId);
                            if (task != null)
                            {
                                userCheckString.TaskName = Convert.ToString(task.name);
                                userCheckString.UserName = Convert.ToString(user.name);
                                userCheckString.UserType = type;
                                userCheckString.CheckTime = Convert.ToString(usrChk.userTime);
                                userCheckString.CheckValue = Convert.ToString(usrChk.userchk1);
                                userCheckString.Description = Convert.ToString(usrChk.userDescription);

                                customerChecks.Add(userCheckString);
                            }
                        }
                    }
                }
            }
            return customerChecks;
        }

        public Dictionary<int, string> getUncheckedEventTasks(int eventId, int userId)
        {
            Dictionary<int, string> eventTasks = new Dictionary<int, string>();

            using(DataClassesDataContext db=new DataClassesDataContext())
            {
                var query = db.Tasks.Where(tsk => tsk.eventId == eventId && !db.UserChks.Where(usrChk => usrChk.taskId == tsk.id && usrChk.userId == userId).Any()).ToList();
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