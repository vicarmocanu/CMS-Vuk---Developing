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
        private static TasksController taskController = new TasksController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WeekEventRepeaterDataBinding();
            }
        }

        private void WeekEventRepeaterDataBinding()
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

        private void EventTaskRepeaterDataBinding(List<TaskStringConversion> importedList)
        {
            List<TaskStringConversion> eventTaskList = new List<TaskStringConversion>();

            try
            {
                eventTaskList = importedList;

                this.EventTaskList.DataSource = eventTaskList;
                this.EventTaskList.DataBind();
            }
            catch (NullReferenceException) { }
        }

        protected void EventList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch(e.CommandName.ToString())
            {
                case "ShowTasks":
                    int eventId = Convert.ToInt32(e.CommandArgument);
                    EventTaskRepeaterDataBinding(taskController.getWantedTasks(eventId));
                    break;
                default:
                    break;
            }
        }


    }
}