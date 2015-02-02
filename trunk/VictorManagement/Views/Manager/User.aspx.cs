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
            ReapeaterDataBinding();
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
    }
}