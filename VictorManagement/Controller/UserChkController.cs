using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;

namespace KibistaManagement.Controller
{
    public class UserChkController
    {
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
    }
}