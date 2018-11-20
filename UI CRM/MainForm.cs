using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FPPG_CRM_v2;

namespace UI_CRM
{
    public partial class MainForm : Form, ICaller
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private bool activebutton = true;

        public MainForm()
        {
            InitializeComponent();
            LoadHomePanel();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            LoadHomePanel();

        }

        public void LoadHomePanel()
        {
            moving_panel.Location = new Point(244, 130);

            changing_panel.Controls.Clear();
            HomeForm home = new HomeForm();
            home.TopLevel = false;
            changing_panel.Controls.Add(home);
            home.Show();

            activebutton = true;
            ControlButtonsEnable();

        }

        public void LoadPersonListPanel()
        {
            moving_panel.Location = new Point(244, 201);

            changing_panel.Controls.Clear();
            PersonListForm people = new PersonListForm(this);
            people.TopLevel = false;
            changing_panel.Controls.Add(people);
            people.Show();
            
            activebutton = true;
            ControlButtonsEnable();

        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            LoadPersonListPanel();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadAddPersonForm()
        {
            changing_panel.Controls.Clear();
            AddPersonForm person = new AddPersonForm(this);
            person.TopLevel = false;
            changing_panel.Controls.Add(person);
            person.Show();

            ControlButtonsDisable();

        }

        public void LoadEditPersonForm(PersonModel person)
        {
            changing_panel.Controls.Clear();
            EditPersonForm customer = new EditPersonForm(person, this);
            customer.TopLevel = false;
            changing_panel.Controls.Add(customer);
            customer.Show();

            ControlButtonsEnable();
        }

        public void LoadTaskByPersonForm(PersonModel person)
        {
            changing_panel.Controls.Clear();
            TaskByPerson customer = new TaskByPerson(person, this);
            customer.TopLevel = false;
            changing_panel.Controls.Add(customer);
            customer.Show();

            ControlButtonsEnable();

        }

        private void task_button_Click(object sender, EventArgs e)
        {
            LoadTaskListPanel();
        }

        public void LoadTaskListPanel()
        {
            moving_panel.Location = new Point(244, 272);
            changing_panel.Controls.Clear();
            TaskListForm tasks = new TaskListForm(this);
            tasks.TopLevel = false;
            changing_panel.Controls.Add(tasks);
            tasks.Show();

            ControlButtonsEnable();

        }

        public void ControlButtonsDisable()
        {                    
 
            home_button.Enabled = false;
            customer_button.Enabled = false;
            task_button.Enabled = false;

        }

        public void ControlButtonsEnable()
        {
            home_button.Enabled = true;
            customer_button.Enabled = true;
            task_button.Enabled = true;
        }
         
        public void LoadEditeTaskForm(TaskModel task)
        {
            moving_panel.Location = new Point(244, 272);
            changing_panel.Controls.Clear();

            EditTaskForm editTask = new EditTaskForm(task, this);
            editTask.TopLevel = false;
            changing_panel.Controls.Add(editTask);
            editTask.Show();
        }

        public void LoadAddTaskForm()
        {
            changing_panel.Controls.Clear();
            AddTaskForm task = new AddTaskForm(this);
            task.TopLevel = false;
            changing_panel.Controls.Add(task);
            task.Show();

            ControlButtonsDisable();
        }
    }
}
