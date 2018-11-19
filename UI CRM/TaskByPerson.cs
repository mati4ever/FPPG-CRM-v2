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
    public partial class TaskByPerson : Form
    {
        ICaller callingForm;
        private PersonModel customer = new PersonModel();
        private bool sort = false;
        

        public TaskByPerson(PersonModel person, ICaller caller)
        {
            InitializeComponent();
            callingForm = caller;
            customer = person;
            customer_combobox.Text = customer.RepresentByLastNameShort;
            InitializeCombobox();
            InitializeTaskList();
        }

        private void InitializeCombobox()
        {
            customer_combobox.DataSource = null;
            customer_combobox.DataSource = GlobalConfig.Connection.GetPerson_All();
            customer_combobox.DisplayMember = "RepresentByLastNameShort";
                        
        }

        private void InitializeTaskList()
        {
            taskList_listbox.DataSource = null;
            taskList_listbox.DataSource = TaskList();
            taskList_listbox.DisplayMember = "RepresentByDateLong";

        }

        private List<TaskModel> TaskList()
        {
            
            if (sort)
            {
                return GlobalConfig.Connection.GetTaskByPerson_Active(customer);
            }
            else
            {
                return GlobalConfig.Connection.GetTaskByPerson_All(customer);
            }
        }

        private void customer_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer = (PersonModel)customer_combobox.SelectedItem;
            InitializeTaskList();
        }

        private void active_button_Click(object sender, EventArgs e)
        {
            if (sort)
            {
                sort = false;
                active_button.BackColor = Color.FromArgb(31, 31, 51);
                InitializeTaskList();
            }
            else
            {
                sort = true;
                active_button.BackColor = Color.Green;
                InitializeTaskList();
            }
        }
    }
}
