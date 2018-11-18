using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_CRM_v2
{
    public class TextConnector : IDataConnector
    {

        private const string PeopleFile = "CustomersFile.csv";
        private const string ConnectionsFile = "Connections.csv";
        private const string TaskCategoryFile = "TaskCategory.csv";
        private const string TaskListFile = "TaskList.csv";



        public void CreateConnection(ConnectionModel connection)
        {
            throw new NotImplementedException();
        }

        public void CreatePerson(PersonModel person)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            people.Add(person);

            people.SaveToPersonFile(PeopleFile);

        }

        public void CreateTask(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            int currentId = 1;

            if (tasks.Count > 0)
            {
                currentId = tasks.OrderByDescending(x => x.Id).First().Id + 1;
            }

            task.Id = currentId;

            tasks.Add(task);

            tasks.SaveToTaskFile(TaskListFile);


        }

        public int GetPersonId()
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            return currentId;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TaskModel> GetTaks_Today()
        {
            List<TaskModel> allTask = GetTask_Active();
            List<TaskModel> output = new List<TaskModel>();

            foreach (TaskModel t in allTask)
            {
                if (t.DateOfExecution.Date.CompareTo(DateTime.Now.Date) == 0 )
                {
                    output.Add(t);
                }
            }
            return output;

        }

        public List<TaskModel> GetTaskByPerson_Active(PersonModel person)
        {
            List<TaskModel> output = new List<TaskModel>();
            List<TaskModel> alltasks = GetTask_All();

            foreach (TaskModel t in alltasks)
            {
                if (t.Person.Id == person.Id && t.Status == false)
                {
                    output.Add(t);
                }
            }
            return output;
        }

        public List<TaskModel> GetTaskByPerson_All(PersonModel person)
        {
            List<TaskModel> output = new List<TaskModel>();
            List<TaskModel> alltasks = GetTask_All();

            foreach (TaskModel t in alltasks)
            {
                if (t.Person.Id == person.Id)
                {
                    output.Add(t);
                }
            }
            return output;
        }

        public List<TaskModel> GetTask_Active()
        {
            List<TaskModel> output = new List<TaskModel>();
            List<TaskModel> alltasks = GetTask_All();

            foreach (TaskModel t in alltasks)
            {
                if (!t.Status)
                {
                    output.Add(t);
                }
            }
            return output;
        }

        public List<TaskModel> GetTask_All()
        {
            return TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);
        }

        public List<TaskModel> GetTask_Close()
        {
            List<TaskModel> allTask = GetTask_Active();
            List<TaskModel> output = new List<TaskModel>();

            foreach (TaskModel t in allTask)
            {
                if ((t.DateOfExecution.Date - DateTime.Now.Date).TotalDays < 7 && t.DateOfExecution.Date.CompareTo(DateTime.Now.Date) > 0)
                {
                    output.Add(t);
                }
            }
            return output;
        }

        public List<TaskModel> GetTask_Missed()
        {
            List<TaskModel> allTask = GetTask_Active();
            List<TaskModel> output = new List<TaskModel>();

            foreach (TaskModel t in allTask)
            {
                if (t.DateOfExecution.Date.CompareTo(DateTime.Now.Date) < 0)
                {
                    output.Add(t);
                }
            }
            return output;
        }

        public void RemovePerson(PersonModel person)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            PersonModel remove = people.Single(x => x.Id == person.Id);
            people.Remove(remove);
            people.SaveToPersonFile(PeopleFile);
        }

        public void RemoveTask(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            TaskModel taskToRemove = tasks.Single(x => x.Id == task.Id);
            tasks.Remove(taskToRemove);
            tasks.SaveToTaskFile(TaskListFile);
            
        }

        public void SaveEditedPerson(PersonModel person)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            PersonModel editedPerson = people.Single(x => x.Id == person.Id);

            people.Remove(editedPerson);
            people.Add(person);
            people.SaveToPersonFile(PeopleFile);
        }

        public void SaveEditedTask(TaskModel task)
        {
            List<TaskModel> tasks = GetTask_All();

            TaskModel editedTask = tasks.Single(x => x.Id == task.Id);

            tasks.Remove(editedTask);
            tasks.Add(task);
            tasks.SaveToTaskFile(TaskListFile);
        }

        public void TaskDelay(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            foreach (TaskModel t in tasks)
            {
                if (t.Id == task.Id)
                {
                    t.DateOfExecution = t.DateOfExecution.AddDays(1);
                }
            }

            tasks.SaveToTaskFile(TaskListFile);
        }

        public void TaskDone(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            foreach (TaskModel t in tasks)
            {
                if (t.Id == task.Id)
                {
                    if (t.Repetition == "none")
                    {
                        t.Status = true;
                    }
                    else if (t.Repetition == "monthly")
                    {
                        t.DateOfExecution = t.DateOfExecution.AddMonths(1);
                    }
                    else if (t.Repetition == "quarterly")
                    {
                        t.DateOfExecution = t.DateOfExecution.AddMonths(3);

                    }
                    else if (t.Repetition == "annual")
                    {
                        t.DateOfExecution = t.DateOfExecution.AddYears(1);
                    }
                    
                }

                tasks.SaveToTaskFile(TaskListFile);
            }
        }


    }
}
