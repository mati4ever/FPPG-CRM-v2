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
    public partial class AddPersonForm : Form
    {
        ICaller callingForm;


        public AddPersonForm(ICaller caller)
        {
            callingForm = caller;
            InitializeComponent();
        }



        private bool Validate()
        {
            if (firstName_textbox.Text.Length == 0 || lastName_textbox.Text.Length == 0)
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
            if (Validate())
            {
                DialogResult dl = MessageBox.Show("Wprowadzone dane zostaną utracone. Kontynuować ?", "", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                {
                    callingForm.LoadPersonListPanel();
                }
            }
        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            if (Validate()) 
            {
                PersonModel person = new PersonModel();

                person.Id = GlobalConfig.Connection.GetPersonId();
                person.FirstName = firstName_textbox.Text;
                person.LastName = lastName_textbox.Text;
                person.Address = address_textbox.Text;
                person.PhoneNumber = phoneNumber_textbox.Text;
                person.EmailAddress = emailAddress_textbox.Text;
                person.PESEL = pesel_textbox.Text;
                person.PersonalIdNumber = personalId_textbox.Text;
                person.Note = note_textbox.Text;

                GlobalConfig.Connection.CreatePerson(person);

                MessageBox.Show("Dodano nowego klienta.");

                callingForm.LoadPersonListPanel();

            }
            else
            {
                MessageBox.Show("Imię i nazwisko są wymaganymi polami.");
            }
        }
    }
}
