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
    public partial class AddTaskForm : Form
    {
        ICaller callingForm;
        private PersonModel customer = new PersonModel();


        public AddTaskForm(ICaller caller)
        {
            callingForm = caller;
            InitializeComponent();
            InitializeList();

            
        }
        public AddTaskForm(ICaller caller, PersonModel person)
        {
            callingForm = caller;
            InitializeComponent();
            InitializeList();

            customer_combobox.SelectedItem = person;
            customer_combobox.Text = person.RepresentByLastNameShort;


        }


        private void InitializeList()
        {
            customer_combobox.DataSource = null;
            customer_combobox.DataSource = GlobalConfig.Connection.GetPerson_All();
            customer_combobox.DisplayMember = "RepresentByLastNameShort";

            category_combobox.DataSource = null;
            category_combobox.DataSource = GlobalConfig.Connection.GetTaskCategory();

            repetition_combobox.Items.Add("Brak");
            repetition_combobox.Items.Add("Miesięczna");
            repetition_combobox.Items.Add("Kwartalna");
            repetition_combobox.Items.Add("Roczna");
            repetition_combobox.Text = "Brak";

            creationDate_textbox.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private bool Validate()
        {
            if (customer_combobox.SelectedItem == null || category_combobox.SelectedItem == null || repetition_combobox.Text.Length ==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            callingForm.LoadTaskListPanel();
        }

        private void addTask_button_Click(object sender, EventArgs e)
        {

            DateTime date1;
            DateTime date2;

            if (DateTime.TryParseExact(creationDate_textbox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date1) &&
                 DateTime.TryParseExact(executionDate_textbox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date2))
            {
                if (Validate())
                {
                    TaskModel task = new TaskModel();
                    task.Person = (PersonModel)customer_combobox.SelectedItem;
                    task.DateOfCreation = date1;
                    task.DateOfExecution = date2;
                    task.Category = (string)category_combobox.SelectedItem;

                    string note = note_textbox.Text;

                    task.Note = GlobalConfig.Connection.ConvertNote(note);

                    task.Repetition = GlobalConfig.Connection.ConverRepetition(repetition_combobox.Text);

                    GlobalConfig.Connection.CreateTask(task);
                    MessageBox.Show("Dodano zadanie");
                    callingForm.LoadTaskListPanel();


                }
                else
                {
                    MessageBox.Show("Wybierz klienta kategorię zadania i jego powtarzalność.");
                }

            }
            else
            {
                MessageBox.Show("Błędny format daty. Poprawny format: DD-MM-RRRR");
            }
        }

        
    }
}
