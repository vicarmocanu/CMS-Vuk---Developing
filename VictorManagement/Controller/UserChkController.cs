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
                Event evt = new Event();
                Task tsk = new Task();
                User usr = new User();

                evt = db.Events.Where(e => e.id == eventId).FirstOrDefault();
                tsk = db.Tasks.Where(t => t.id == taskId).FirstOrDefault();
                usr = db.Users.Where(u => u.id == userId).FirstOrDefault();

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

        //get the customer check for a particular event and task
        public UserChk getCustomerChk(int eventId, int taskId,)
        {
            UserChk usrCheck1 = new UserChk();

            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.UserChks.Where(chk => chk.eventId == eventId && chk.taskId == taskId).ToList();
                List<UserChk> checks = query;

                foreach(UserChk usChk in checks)
                {
                    int userId = 0;
                    userId = usChk.userId;
                    User user = new User();
                    user = db.Users.SingleOrDefault(usr => usr.id == userId);
                    if(user != null)
                    {
                        String types = Convert.ToString(user.types);
                        if(types.Equals("Customer") == true)
                        {
                            usrCheck1 = usChk;
                        }
                    }                    
                }
            }

            return usrCheck1;            
        }

        //get the employee check for a particular event and task
        public UserChk getEmployeeChk(int eventId, int taskId)
        {
            UserChk usrCheck2 = new UserChk();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.UserChks.Where(chk => chk.eventId == eventId && chk.taskId == taskId).ToList();
                List<UserChk> checks = query;

                foreach (UserChk usChk in checks)
                {
                    int userId = 0;
                    userId = usChk.userId;
                    User user = new User();
                    user = db.Users.SingleOrDefault(usr => usr.id == userId);
                    if (user != null)
                    {
                        String types = Convert.ToString(user.types);
                        if (types.Equals("Employee") == true)
                        {
                            usrCheck2 = usChk;
                        }
                    }
                }
            }

            return usrCheck2;            
        }

        //get the actual check for an entity
        public bool getTheCheck(UserChk usrChk)
        {
            bool check = false;

            check = Convert.ToBoolean(usrChk.userchk1);

            return check;
        }

        //get the actual desc for am entity
        public String getTheDesc(UserChk usrChk)
        {
            String desc = "";

            desc = Convert.ToString(usrChk.userDescription);

            return desc;
        }
    }
}