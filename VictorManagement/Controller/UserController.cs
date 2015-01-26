using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VictorManagement.Model;

namespace VictorManagement.Controller
{
    public class UserController
    {
        public void insertUser(String name, String pass, String email, String types, String phoneNr)
        {
            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                User user = new User();

                user.name = name;
                user.pass = pass;
                user.phoneNr = phoneNr;
                user.email = email;
                user.types = types;

                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
            }
        }
    }
}