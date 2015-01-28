using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KibistaManagement.Controller;
using KibistaManagement.Model;

namespace KibistaManagement.Views.Management
{
    public partial class Home : System.Web.UI.Page
    {
        private static EventController eventController = new EventController();

        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterDataBinding();
        }

        public void RepeaterDataBinding()
        {
            List<EventStringConversion> eventList = new List<EventStringConversion>();

            try
            {
                eventList = eventController.repeaterListGeneration();

                this.EventList.DataSource = eventList;
                this.EventList.DataBind();
            }
            catch (NullReferenceException) { }
        }
    }
}