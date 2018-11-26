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
    public partial class EditTaskForm : Form
    {
        ICaller callingForm;
        TaskModel task = new TaskModel();
        private bool editing = false;

        public EditTaskForm(TaskModel task, ICaller caller)
        {
            callingForm = caller;
            this.task = task;
            InitializeComponent();
            InitializeList();
            InitializeControls();
        }

        private void InitializeControls()
        {
            customer_combobox.Text = task.Person.RepresentByLastNameShort;
            creationDate_textbox.Text = task.DateOfCreation.ToString("dd-MM-yyyy");
            executionDate_textbox.Text = task.DateOfExecution.ToString("dd-MM-yyyy");
            category_combobox.Text = task.Category;
            repetition_combobox.Text = GlobalConfig.Connection.ReverseConverRepetition(task.Repetition);
            note_textbox.Text = GlobalConfig.Connection.LoadNote(task.Note);
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

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                DialogResult dl = MessageBox.Show("Czy chcesz wyjść bez zapisania ?", "", MessageBoxButtons.YesNo);
                if (dl== DialogResult.Yes)
                {
                    callingForm.LoadTaskListPanel();
                }
            }
            else
            {
                callingForm.LoadTaskListPanel();
            }
        }

        private void editCustomer_button_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void EnableControls()
        {
            editing = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag =="ED")
                {
                    ctrl.Enabled = true;
                }
            }
            editCustomer_button.Enabled = false;

        }

        private void DisableControls()
        {
            editing = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag == "ED")
                {
                    ctrl.Enabled = false;
                }
            }
            editCustomer_button.Enabled = true;
        }

        private void saveCustomer_button_Click(object sender, EventArgs e)
        {
            DateTime date1;

            if (DateTime.TryParseExact(executionDate_textbox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date1))
            {
                if (Validate())
                {
                    TaskModel editedTask = new TaskModel();
                    editedTask.Id = this.task.Id;
                    editedTask.Person = this.task.Person;
                    editedTask.DateOfCreation = this.task.DateOfCreation;
                    editedTask.DateOfExecution = date1;
                    editedTask.Category = (string)category_combobox.SelectedItem;

                    string note = note_textbox.Text;

                    editedTask.Note = GlobalConfig.Connection.ConvertNote(note);

                    editedTask.Repetition = task.Repetition = GlobalConfig.Connection.ConverRepetition(repetition_combobox.Text);

                    GlobalConfig.Connection.SaveEditedTask(editedTask);
                    MessageBox.Show("Zapisano zmiany");
                    DisableControls();
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
        private bool Validate()
        {
            if (customer_combobox.SelectedItem == null || category_combobox.SelectedItem == null || repetition_combobox.Text.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
