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
    public partial class EditPersonForm : Form
    {
        ICaller callingForm;
        private PersonModel customer = new PersonModel();
        private bool editing = false;

        public EditPersonForm(PersonModel person, ICaller caller)
        {
           callingForm = caller;
           customer = person;

           InitializeComponent();
           InitializeControls();
           InitializeLists();
        }

        private void InitializeControls()
        {
            firstName_textbox.Text = customer.FirstName;
            lastName_textbox.Text = customer.LastName;
            address_textbox.Text = customer.Address;
            phoneNumber_textbox.Text = customer.PhoneNumber;
            emailAddress_textbox.Text = customer.EmailAddress;
            pesel_textbox.Text = customer.PESEL;
            personalId_textbox.Text = customer.PersonalIdNumber;
            note_textbox.Text = customer.Note;
        }

        private void InitializeLists()
        {
            task_listbox.DataSource = null;
            task_listbox.DataSource = GlobalConfig.Connection.GetTaskByPerson_Active(customer);
            task_listbox.DisplayMember = "RepresentForPerson";

            connection_listbox.DataSource = null;
            connection_listbox.DataSource = GlobalConfig.Connection.GetConnectionsByPerson_All(customer);
            connection_listbox.DisplayMember = "RepresentByLastNameShort";

            connection_combobox.DataSource = null;
            connection_combobox.DataSource = GlobalConfig.Connection.AvaliableConnections(customer);
            connection_combobox.DisplayMember = "RepresentByLastNameShort";

        }



        private void editCustomer_button_Click(object sender, EventArgs e)
        {
            editing = true;
            EnableControls();
            callingForm.ControlButtonsDisable();
        }

        
        private void EnableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag == "ED")
                {
                    ctrl.Enabled = true;
                }

            }

            editCustomer_button.Enabled = false;
            taskDetails_button.Enabled = false;
            showConnection_button.Enabled = false;

        }

        private void DisableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag == "ED")
                {
                    ctrl.Enabled = false;
                }

            }

            editCustomer_button.Enabled = true;
            taskDetails_button.Enabled = true;
            showConnection_button.Enabled = true;
        }


        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                DialogResult dl = MessageBox.Show("Czy chcesz wyjść bez zapisania ?", "", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                {
                    callingForm.LoadPersonListPanel();
                }
            }
            else
            {
                callingForm.LoadPersonListPanel();
            }
        }

        private void saveCustomer_button_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                PersonModel person = new PersonModel();

                person.Id = customer.Id;
                person.FirstName = firstName_textbox.Text;
                person.LastName = lastName_textbox.Text;
                person.Address = address_textbox.Text;
                person.PhoneNumber = phoneNumber_textbox.Text;
                person.EmailAddress = emailAddress_textbox.Text;
                person.PESEL = pesel_textbox.Text;
                person.PersonalIdNumber = personalId_textbox.Text;
                person.Note = note_textbox.Text;

                GlobalConfig.Connection.SaveEditedPerson(person);

                MessageBox.Show("Zapisano zmiany.");
                editing = false;
                DisableControls();

                callingForm.ControlButtonsEnable();
            }
            else
            {
                MessageBox.Show("Imię i nazwisko są wymaganymi polami.");
            }
        }

        private bool Validate()
        {
            if (firstName_textbox.Text.Length == 0 || lastName_textbox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void taskDetails_button_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)task_listbox.SelectedItem;
            callingForm.LoadEditeTaskForm(task);
        }

        private void addConnection_button_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)connection_combobox.SelectedItem;
            ConnectionModel connection = new ConnectionModel();
            connection.FirstPerson = customer;
            connection.SecondPerson = person;

            GlobalConfig.Connection.CreateConnection(connection);
            InitializeLists();
        }

        private void removeConnection_button_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)connection_listbox.SelectedItem;
            GlobalConfig.Connection.RemoveConnection(customer, person);
            InitializeLists();
        }

        private void showConnection_button_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)connection_listbox.SelectedItem;
            callingForm.LoadEditPersonForm(person);
        }
    }
}
