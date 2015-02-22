using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KibistaManagement.Controller;
using KibistaManagement.Model;

namespace KibistaManagement.Views.Customer
{
    public partial class Verify : System.Web.UI.Page
    {
        private static EventController eventController = new EventController();
        private static TasksController taskController = new TasksController();
        private static UserChkController userCheckController = new UserChkController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EventListDataBind();
            }
        }

        //data bind for the events dropdown
        private void EventListDataBind()
        {
            Dictionary<int, string> events = new Dictionary<int, string>();
            events = eventController.getEventsFor3Days();

            this.eventsList.DataSource = events;
            this.eventsList.DataValueField = "Key";
            this.eventsList.DataTextField = "Value";
            this.eventsList.DataBind();
        }

        private void consistency()
        {
            List<Task> emptyList = new List<Task>();

            this.TaskName.Text = "";
            this.TaskDescription.Text = "";
            this.TaskDescriptionPanel.Visible = false;
            this.yesCheck.Checked = false;
            this.noCheck.Checked = false;
            this.PerformCheckPanel.Visible = false;
        }

        protected void eventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tasksList.Items.Clear();
            consistency();

        }

        //data bind for the event tasks dropdown
        private void TaskListDataBind(int eventId)
        {
            Dictionary<int, string> eventTasks = new Dictionary<int, string>();
            eventTasks = userCheckController.getUncheckedEventTasks(eventId, 1); //vezi ca aici va trebui sa faci un session si sa faci transfer de user id de pe un form pe altul

            this.tasksList.DataSource = eventTasks;
            this.tasksList.DataValueField = "Key";
            this.tasksList.DataTextField = "Value";
            this.tasksList.DataBind();
        }

        protected void getTasks_Click(object sender, EventArgs e)
        {
            int eventId = Convert.ToInt32(eventsList.SelectedValue);
            TaskListDataBind(eventId);
        }

        protected void tasksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            consistency();
        }

        protected void taskDetails_Click(object sender, EventArgs e)
        {
            int taskId = Convert.ToInt32(tasksList.SelectedValue);
            this.TaskName.Text = Convert.ToString(taskController.getTaskById(taskId).name);
            this.TaskDescription.Text = Convert.ToString(taskController.getTaskById(taskId).descrip);

            if(this.TaskDescriptionPanel.Visible == false)
            {
                this.TaskDescriptionPanel.Visible = true;
            }                                  
        }

        protected void checkButton_Click(object sender, EventArgs e)
        {
            if(this.PerformCheckPanel.Visible == false)
            {
                this.PerformCheckPanel.Visible = true;
            }
        }

        protected void completeCheck_Click(object sender, EventArgs e)
        {
            int eventId = Convert.ToInt32(eventsList.SelectedValue);
            int taskId = Convert.ToInt32(tasksList.SelectedValue);
            String comment = this.userCommentTextBox.Text.ToString();
            if(yesCheck.Checked == true)
            {
                userCheckController.createUserChk(eventId, taskId, 1, DateTime.Now, comment, true); //vezi ca 1 acolo trebuie schimbat sa fie dinamic
                this.warningCheck.Visible = false;
                this.tasksList.Items.Clear();
                consistency();
            }
            else
            {
                if(noCheck.Checked == true)
                {
                    userCheckController.createUserChk(eventId, taskId, 1, DateTime.Now, comment, false); //vezi ca 1 acolo trebuie schimbat sa fie dinamic
                    this.warningCheck.Visible = false;
                    this.tasksList.Items.Clear();
                    consistency();
                }
                else
                {
                    this.warningCheck.Visible = true;
                }
            }            
        }

        protected void yesCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.noCheck.Checked = false;
        }

        protected void noCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.yesCheck.Checked = false;
        }
    }
}