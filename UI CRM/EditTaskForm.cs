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

        public EditTaskForm(TaskModel task, ICaller caller)
        {
            callingForm = caller;
            this.task = task;
            InitializeComponent();
        }
    }
}
