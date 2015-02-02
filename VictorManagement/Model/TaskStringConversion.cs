using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KibistaManagement.Model
{
    public class TaskStringConversion
    {
        private String id;
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        private String eventId;
        public String EventId
        {
            get { return eventId; }
            set { eventId = value; }
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
    }
}