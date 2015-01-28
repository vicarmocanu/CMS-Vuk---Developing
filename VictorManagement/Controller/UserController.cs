using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KibistaManagement.Model;

namespace KibistaManagement.Controller
{
    public class UserController
    {
        // #create
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

        // #read
        public User getUserById(int id)
        {
            User user = new User();
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                user = db.Users.SingleOrDefault(userGet => userGet.id == id);
            }
            return user;
        }

        // #update 
        public void updateUserById(int id, String name, String pass, String email, String types, String phoneNr)
        {
            User user = new User();
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                user = db.Users.SingleOrDefault(userUpdate => userUpdate.id == id);

                try
                {
                    if (user.Equals(null) != true)
                    {
                        user.name = name;
                        user.pass = pass;
                        user.email = email;
                        user.types = types;

                        db.SubmitChanges();
                    }
                }
                catch (NullReferenceException) { }                
            }
        }

        public User getUserByEmail(String email)
        {
            User usr = new User();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                usr = db.Users.SingleOrDefault(us => us.email.Equals(email));
            }


            return usr;

        }

        public String getUserTypes(User user)
        {
            String type = "";

            if (user != null)
            {
                type = user.types;

            }
            return type;
        }

        

        // #nodelete
    }
}