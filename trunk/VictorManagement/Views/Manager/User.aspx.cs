using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KibistaManagement.Model;
using KibistaManagement.Controller;

namespace KibistaManagement.Views.Management
{
    public partial class User : System.Web.UI.Page
    {
        public static UserController userCtr = new UserController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReapeaterDataBinding();
            }
        }

        public void ReapeaterDataBinding()
        {
  
            List<UserStringConversion> userLists = new List<UserStringConversion>();

            try
            {
                userLists = userCtr.repeaterListGeneration();

                this.UserRepeater.DataSource = userLists;
                this.UserRepeater.DataBind();
            }
            catch(NullReferenceException){}
        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Manager/CreateUser.aspx");
        }

        protected void UserRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch(e.CommandName.ToString())
            {
                case "userUpdate":
                    int userId = 0;
                    userId = Convert.ToInt32(e.CommandArgument);
                    Session["userId"]= userId;
                    Response.Redirect("~/Views/Manager/UpdateUser.aspx");
                    break;
                default:
                    break;

            }
        }
    }
}