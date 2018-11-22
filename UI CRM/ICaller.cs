using FPPG_CRM_v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_CRM
{
    public interface ICaller
    {
        void LoadAddPersonForm();
        void LoadEditPersonForm(PersonModel person);
        void LoadTaskByPersonForm(PersonModel person);
        void LoadHomePanel();
        void LoadPersonListPanel();
        void LoadTaskListPanel();
        void LoadEditeTaskForm(TaskModel task);
        void LoadAddTaskForm();
        void LoadAddTaskForm(PersonModel person);



        void ControlButtonsEnable();
        void ControlButtonsDisable();
    }
}
