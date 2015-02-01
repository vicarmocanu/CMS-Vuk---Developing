using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KibistaManagement.Model
{
    public class UserStringConversion
    {
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String pass;

        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String type;

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
        private String phoneNr;

        public String PhoneNr
        {
            get { return phoneNr; }
            set { phoneNr = value; }
        }

    }
}