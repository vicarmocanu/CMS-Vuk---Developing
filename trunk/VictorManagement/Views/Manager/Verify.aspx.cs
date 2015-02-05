using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KibistaManagement.Controller;
using KibistaManagement.Model;
using System.Collections;

namespace KibistaManagement.Views.Management
{
    public partial class Verify : System.Web.UI.Page
    {
        private static EventController eventController = new EventController();
        private static TasksController taskController = new TasksController();
        private static UserChkController userCheckController = new UserChkController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                EventListDataBind();
            }
        }

        //data bind for the events dropdown
        private void EventListDataBind()
        {
            Dictionary<int, string> events = new Dictionary<int,string>();
            events = eventController.getEventsFor3Days();

            this.eventsList.DataSource = events;
            this.eventsList.DataValueField = "Key";
            this.eventsList.DataTextField = "Value";            
            this.eventsList.DataBind();
        }

        //data bind for the event tasks dropdown
        private void TaskListDataBind(int eventId)
        {
            Dictionary<int, string> eventTasks = new Dictionary<int, string>();
            eventTasks = taskController.getEventTasks_Dictionary(eventId);

            this.tasksList.DataSource = eventTasks;
            this.tasksList.DataValueField = "Key";
            this.tasksList.DataTextField = "Value";
            this.tasksList.DataBind();
        }

        //Search tasks button
        protected void tasksSearch_Click(object sender, EventArgs e)
        {
            TaskListDataBind(Convert.ToInt32(eventsList.SelectedValue));
        }

        private void consistency()
        {
            List<UserCheckStringConversion> emptyList = new List<UserCheckStringConversion>();

            this.CustomerTasksCheckRepeater.DataSource = emptyList;
            this.CustomerTasksCheckRepeater.DataBind();
            this.EmployeeTaskCheckRepeater.DataSource = emptyList;
            this.EmployeeTaskCheckRepeater.DataBind();
        }

        //consistency from the event dropdown
        protected void eventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tasksList.Items.Clear();
            consistency();
            
        }

        //consistency from the task dropdown
        protected void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            consistency();
        }

        //Get checks button
        protected void checksSearch_Click(object sender, EventArgs e)
        {
            int eventId = 0;
            int taskId = 0;
            String userType1 = "Customer";
            String userType2 = "Employee";
            
            if (this.tasksList.Items.Count != 0)
            {
                eventId = Convert.ToInt32(this.eventsList.SelectedValue);
                taskId = Convert.ToInt32(this.tasksList.SelectedValue);
                
                CustomerTasksCheckRepeaterDataBinding(userCheckController.getUserChecks(eventId, taskId, userType1));
                EmployeeTaskCheckRepeaterDataBinding(userCheckController.getUserChecks(eventId, taskId, userType2));
            }           
        }

        //customer checks
        private void CustomerTasksCheckRepeaterDataBinding(List<UserCheckStringConversion> importedList)
        {
            List<UserCheckStringConversion> customerChecks = new List<UserCheckStringConversion>();
            
            customerChecks = importedList;
            
            this.CustomerTasksCheckRepeater.DataSource = customerChecks;
            this.CustomerTasksCheckRepeater.DataBind();        
        }

        //employee checks
        private void EmployeeTaskCheckRepeaterDataBinding(List<UserCheckStringConversion> importedList2)
        {
            List<UserCheckStringConversion> employeeChecks = new List<UserCheckStringConversion>();

            employeeChecks = importedList2;

            this.EmployeeTaskCheckRepeater.DataSource = employeeChecks;
            this.EmployeeTaskCheckRepeater.DataBind();
        }
    }
}