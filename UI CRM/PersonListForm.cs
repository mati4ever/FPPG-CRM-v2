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
    public partial class PersonListForm : Form
    {
        private string represent = "RepresentByID";
        private bool active = false;
        ICaller callingForm;


        public PersonListForm(ICaller caller)
        {
            callingForm = caller;
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            person_listbox.DataSource = null;
            person_listbox.DataSource = GlobalConfig.Connection.GetPerson_All();
            person_listbox.DisplayMember = represent;

        }

        private void alfabetic_button_Click(object sender, EventArgs e)
        {
            if (active)
            {
                active = false;
                alfabetic_button.BackColor = Color.FromArgb(31, 31, 51);
                represent = "RepresentByID";
                InitializeList();
            }
            else
            {
                active = true;
                alfabetic_button.BackColor = Color.Green;
                represent = "RepresentByLastName";
                InitializeList();
            }
            
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                DialogResult dl = MessageBox.Show("Czy napewno chcesz usunąć klienta?", "", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                {
                    PersonModel person = (PersonModel)person_listbox.SelectedItem;
                    GlobalConfig.Connection.RemovePerson(person);
                    InitializeList();
                }
            }


        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            callingForm.LoadAddPersonForm();
        }

        private void fullProfile_button_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                PersonModel person = (PersonModel)person_listbox.SelectedItem;
                callingForm.LoadEditPersonForm(person);
            }

        }

        private void customerTask_button_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                PersonModel person = (PersonModel)person_listbox.SelectedItem;
                callingForm.LoadTaskByPersonForm(person);
            }
            
        }

        private bool Selected()
        {
            if (person_listbox.SelectedItem != null)
            {
                return true;
            }
            return false;
        }
    }
}
