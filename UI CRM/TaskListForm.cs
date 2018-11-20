using FPPG_CRM_v2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CRM
{
    public partial class TaskListForm : Form
    {
        ICaller callingForm;
        private bool sort = false;

        public TaskListForm(ICaller caller)
        {
            callingForm = caller;
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            task_listbox.DataSource = null;
            task_listbox.DataSource = TaskList();
            task_listbox.DisplayMember = "RepresentByDate";
        }

        private List<TaskModel> TaskList()
        {
            if (sort)
            {
                return GlobalConfig.Connection.GetTask_Active();
            }
            else
            {
                return GlobalConfig.Connection.GetTask_All();
            }
        }

        private void addTask_button_Click(object sender, EventArgs e)
        {
            callingForm.LoadAddTaskForm();
        }

        private void active_button_Click(object sender, EventArgs e)
        {
            if (sort)
            {
                sort = false;
                active_button.BackColor = Color.FromArgb(31, 31, 51);
                InitializeList();
            }
            else
            {
                sort = true;
                active_button.BackColor = Color.Green;
                InitializeList();
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                DialogResult dl = MessageBox.Show("Czy napewno chcesz usunąć zadanie?", "", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                {
                    TaskModel task = (TaskModel)task_listbox.SelectedItem;
                    GlobalConfig.Connection.RemoveTask(task);
                    InitializeList();
                }
            }



        }

        private void taskDone_button_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                TaskModel task = (TaskModel)task_listbox.SelectedItem;
                GlobalConfig.Connection.TaskDone(task);
                InitializeList();
            }
            
        }

        private void taskDetails_button_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                TaskModel task = (TaskModel)task_listbox.SelectedItem;
                callingForm.LoadEditeTaskForm(task);
            }
      
        }

        private bool Selected()
        {
            if (task_listbox.SelectedItem != null)
            {
                return true;
            }
            return false;
        }
    }
}
