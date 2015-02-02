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

        public List<UserStringConversion> repeaterListGeneration()
        {
            List<UserStringConversion> stringUserList = new List<UserStringConversion>();

            List<User> users = new List<User>();

            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                var query = db.Users.Where(usr => usr.id >= 0).ToList();
                users = query;
            }
            
            foreach (User us in users)
            {
                UserStringConversion usersInString = new UserStringConversion();

                usersInString.Id = Convert.ToString(us.id);
                usersInString.Name = Convert.ToString(us.name);
                usersInString.Pass = Convert.ToString(us.pass);
                usersInString.PhoneNr = Convert.ToString(us.phoneNr);
                usersInString.Type = Convert.ToString(us.types);
                usersInString.Email = Convert.ToString(us.email);

                stringUserList.Add(usersInString);
            }

            return stringUserList;
        }

        

        // #nodelete
    }
}