using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KibistaManagement.Model;
using KibistaManagement.Controller;

namespace KibistaManagement.Views.LogIn
{
    public partial class LogIn : System.Web.UI.Page
    {
        private static UserController usrCtr = new UserController();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String typeValue = "";
            String emailValue = "";
            emailValue = txtEmail.Text.ToString();
            User usr = new User();
            usr = usrCtr.getUserByEmail(emailValue);
            if (usr != null)
            {
                typeValue = usrCtr.getUserTypes(usr);
                if (typeValue == "Manager")
                {
                    Server.Transfer("~/Views/LogIn/Error.aspx");
                }
                else
                {
                    Server.Transfer("~/Views/LogIn/Error.aspx");
                }
            }
            else
            {
                Server.Transfer("~/Views/LogIn/Error.aspx");
            }
        }
    }
}