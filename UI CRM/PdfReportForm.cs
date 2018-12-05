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
    public partial class PdfReportForm : Form
    {

        private List<TaskModel> allTasks = new List<TaskModel>();
        private List<TaskModel> FilteredTasks = new List<TaskModel>();
        private DateTime date1;
        private DateTime date2;
        bool usedatefilter = true;

        int status = 1;
        int category = 1;
        int repetition = 1;


        public PdfReportForm()
        {
            InitializeComponent();
            Default();
        }

        private void Default()
        {
            statusAll_radiobutton.Checked = true;
            categoryAll_radiobutton.Checked = true;
            repetitionAll_radiobutton.Checked = true;


        }

        private void D(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path;

            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderDialog.SelectedPath.ToString();

                    //MessageBox.Show($@"{path}\Raport z dnia: {DateTime.Now.ToString("dd-MM-yyyy")}");

                    PdfCreator pdf = new PdfCreator();
                    pdf.FileName = $@"{path}\Raport z dnia_{DateTime.Now.ToString("dd-MM-yyyy")}";
                    pdf.Lista = FilteredTasks;
                    pdf.CreateReport();

                    
                    // pdf.Lista = FilteredTasks;
                    // pdf.CreateReport();
                }
            }

  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TaskModel> output = new List<TaskModel>();

            output = FirstFilter();
            output = SecondFilter(output);
            output = ThirdFilter(output);

            if (usedatefilter)
            {

                date1 = date1_datePicekr.Value;
                date2 = date2_datePicker.Value;            

                output = DateFilter(output);
                
            }

            foundElements_textbox.Text = output.Count().ToString();
            FilteredTasks = output;

        }




        private List<TaskModel> FirstFilter()
        {

            List<TaskModel> output = new List<TaskModel>();

            switch (status)
            {
                case 1:
                    output = GlobalConfig.Connection.GetTask_All();
                    break;

                case 2:

                    output = GlobalConfig.Connection.GetTask_Active();

                    break;

                case 3:

                    output = GlobalConfig.Connection.GetTask_Missed();

                    break;

                default:
                    break;
            }

            return output;
        }

        private List<TaskModel> SecondFilter (List<TaskModel> list)
        {
            List<TaskModel> output = new List<TaskModel>();

            switch (category)
            {
                case 1:
                    output = list;
                    break;
                case 2:

                    foreach (TaskModel t in list)
                    {
                        if (t.Category == "Spotkanie")
                        {
                            output.Add(t);
                        }
                    }

                    break;
                case 3:

                    foreach (TaskModel t in list)
                    {
                        if (t.Category == "Telefon")
                        {
                            output.Add(t);
                        }
                    }
                    break;
                case 4:

                    foreach (TaskModel t in list)
                    {
                        if (t.Category == "E-mail")
                        {
                            output.Add(t);
                        }
                    }
                    break;
                default:
                    break;
            }

            return output;

        }
            
        private List<TaskModel> ThirdFilter (List<TaskModel> list)
        {
            List<TaskModel> output = new List<TaskModel>();
            switch (repetition)
            {
                case 1:
                    output = list;
                    break;
                case 2:
                    foreach (TaskModel t in list)
                    {
                        if (t.Repetition == "monthly")
                        {
                            output.Add(t);
                        }
                    }
                    break;
                case 3:
                    foreach (TaskModel t in list)
                    {
                        if (t.Repetition == "quarterly")
                        {
                            output.Add(t);
                        }
                    }
                    break;
                case 4:
                    foreach (TaskModel t in list)
                    {
                        if (t.Repetition == "annual")
                        {
                            output.Add(t);
                        }
                    }
                    break;


                default:
                    break;
            }
            return output;
        }

        private List<TaskModel> DateFilter (List<TaskModel> list)
        {
            List<TaskModel> output = new List<TaskModel>();

            foreach (TaskModel t in list)
            {
                if ((t.DateOfExecution.Date - date1).TotalDays >=-1 && (date2 - t.DateOfExecution).TotalDays >=0)
                {
                    output.Add(t);
                }
            }
            return output;

        }


        private void statusMissed_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            date1_datePicekr.Enabled = false;
            date2_datePicker.Enabled = false;
            
            status = 3;
            usedatefilter = false;

        }

        private void statusActive_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            date1_datePicekr.Enabled = true;
            date2_datePicker.Enabled = true;
            status = 2;
            usedatefilter = true;
        }

        private void statusAll_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            date1_datePicekr.Enabled = true;
            date2_datePicker.Enabled = true;
            status = 1;
            usedatefilter = true;
        }

        private void categoryAll_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            category = 1;
        }

        private void categoryMeating_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            category = 2;
        
        }

        private void categoryCall_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            category = 3;
        }

        private void categoryMail_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            category = 4;
        }

        private void repetitionAll_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            repetition = 1;
        }

        private void repetitionMonthly_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            repetition = 2;
        }

        private void repetitionQuarterly_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            repetition = 3;
        }

        private void repetitionAnnually_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            repetition = 4;
        }
    }
}
