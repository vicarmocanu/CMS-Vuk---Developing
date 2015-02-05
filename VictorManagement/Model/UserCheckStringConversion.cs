using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KibistaManagement.Model
{
    public class UserCheckStringConversion
    {
        private string taskName;        
        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }

        private string userName;        
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string userType;
        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        private string checkTime;
        public string CheckTime
        {
            get { return checkTime; }
            set { checkTime = value; }
        }

        private string checkValue;
        public string CheckValue
        {
            get { return checkValue; }
            set { checkValue = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}