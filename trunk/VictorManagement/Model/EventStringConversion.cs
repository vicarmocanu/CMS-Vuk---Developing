using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KibistaManagement.Model
{
    public class EventStringConversion
    {
        private String Id;

        public String ID
        {
            get { return Id; }
            set { Id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String descrip;

        public String Descrip
        {
            get { return descrip; }
            set { descrip = value; }
        }

        private String startTime;

        public String StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private String endTime;

        public String EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        private String location;

        public String Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}