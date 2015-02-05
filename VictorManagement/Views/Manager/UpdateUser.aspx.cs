using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KibistaManagement.Controller;
using KibistaManagement.Model;

namespace KibistaManagement.Views.Manager
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        private int userId = 0;
        private static UserController userController = new UserController();

        protected void Page_Load(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(Session["userId"]);
            if(!IsPostBack)
            {
                UserRepeaterDataBinding();
            }

        }

        private void UserRepeaterDataBinding()
        {
            List<UserStringConversion> userList = new List<UserStringConversion>();
            userId = Convert.ToInt32(Session["userId"]);
            UserStringConversion stringUser = new UserStringConversion();
            stringUser = userController.getStringUser(userId);
            userList.Add(stringUser);

            this.UserRepeater.DataSource = userList;
            this.UserRepeater.DataBind();
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(txtName.Text);
                string pass = Convert.ToString(txtPassword.Text);
                string email = Convert.ToString(txtEmail.Text);
                string type = Convert.ToString(typesDropdown.SelectedItem.Text);
                string phoneNr = Convert.ToString(txtPhoneNr.Text);

                userController.updateUserById(userId, name, pass, email, type, phoneNr);
                Response.Redirect("~/Views/Manager/User.aspx");
            }
            catch (NullReferenceException) { }
        }
    }
}