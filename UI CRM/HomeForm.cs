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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            todaysTask_listbox.DataSource = null;
            todaysTask_listbox.DataSource = GlobalConfig.Connection.GetTaks_Today();
            todaysTask_listbox.DisplayMember = "RepresentByDate";

            closeTask_listbox.DataSource = null;
            closeTask_listbox.DataSource = GlobalConfig.Connection.GetTask_Close();
            closeTask_listbox.DisplayMember = "RepresentByDate";

            missedTask_listbox.DataSource = null;
            missedTask_listbox.DataSource = GlobalConfig.Connection.GetTask_Missed();
            missedTask_listbox.DisplayMember = "RepresentByDate";

        }

        private void todayTaskDone_button_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)todaysTask_listbox.SelectedItem;
            TaskDone(task);
        }

        private void DelayTask(TaskModel task)
        {
            GlobalConfig.Connection.TaskDelay(task);
            InitializeList();
        }

        private void TaskDone(TaskModel task)
        {
            GlobalConfig.Connection.TaskDone(task);
            InitializeList();
        }

        private void closeTaskDone_button_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)closeTask_listbox.SelectedItem;
            TaskDone(task);
        }

        private void todayTaskDelay_button_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)todaysTask_listbox.SelectedItem;
            DelayTask(task);
        }

        private void closeTaskDelay_button_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)closeTask_listbox.SelectedItem;
            DelayTask(task);
        }

        private void removeTask_button_Click(object sender, EventArgs e)
        {
            if (missedTask_listbox.SelectedItem != null)
            {
                DialogResult dl = MessageBox.Show("Czy napewno chcesz usunać zadanie?", "", MessageBoxButtons.YesNo);

                if (dl == DialogResult.Yes)
                {
                    TaskModel task = (TaskModel)missedTask_listbox.SelectedItem;
                    GlobalConfig.Connection.RemoveTask(task);
                }
            }

            
        }

        private void missedTaskDone_button_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)missedTask_listbox.SelectedItem;
            TaskDone(task);
        }
    }
}
