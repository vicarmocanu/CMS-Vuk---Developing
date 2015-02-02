using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KibistaManagement.Controller;

namespace KibistaManagement.Views.Manager
{
    public partial class CreateUser : System.Web.UI.Page
    {
        private static UserController userCtr = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(txtName.Text);
                string pass = Convert.ToString(txtPassword.Text);
                string email = Convert.ToString(txtEmail.Text);
                string type = Convert.ToString(txtType.Text);
                string phoneNr = Convert.ToString(txtPhoneNr.Text);

                userCtr.insertUser(name, pass, email, type, phoneNr);
                Response.Redirect("~/Views/Manager/User.aspx");
                
            }
            catch(NullReferenceException)
            {}

        }


    }
}