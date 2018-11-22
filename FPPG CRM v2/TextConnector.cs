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

        public List<PersonModel> AvaliableConnections(PersonModel person)
        {
            List<PersonModel> people = GlobalConfig.Connection.GetPerson_All();
            List<PersonModel> connected = GlobalConfig.Connection.GetConnectionsByPerson_All(person);


            foreach (PersonModel p in connected)
            {
                PersonModel remove = people.Single(x => x.Id == p.Id);
                people.Remove(remove);

            }
            PersonModel removex = people.Single(x => x.Id == person.Id);
            people.Remove(removex);

            return people;
        }

        public void CreateConnection(ConnectionModel connection)
        {
            List<ConnectionModel> connections = ConnectionsFile.FullFilePath().LoadFile().ConvertToConnectionModel(GetPerson_All());

            int currentId = 1;

            if (connections.Count > 0)
            {
                currentId = connections.OrderByDescending(x => x.Id).First().Id + 1;
            }
            connection.Id = currentId;
            connections.Add(connection);

            connections.SaveToConnectionFile(ConnectionsFile);
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

        public List<PersonModel> GetConnectionsByPerson_All(PersonModel person)
        {
            List<ConnectionModel> connections = ConnectionsFile.FullFilePath().LoadFile().ConvertToConnectionModel(GetPerson_All());
            List<PersonModel> output = new List<PersonModel>();

            foreach (ConnectionModel c in connections)
            {
                if (c.FirstPerson.Id == person.Id)
                {
                    output.Add(c.SecondPerson);
                }
                else if (c.SecondPerson.Id == person.Id)
                {
                    output.Add(c.FirstPerson);
                }

            }

            return output;

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

        public List<string> GetTaskCategory()
        {
            List<string> category = TaskCategoryFile.FullFilePath().LoadFile();
            return category;
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

        public void RemoveConnection(PersonModel firstPerson, PersonModel secondPerson)
        {
            List<ConnectionModel> connections = ConnectionsFile.FullFilePath().LoadFile().ConvertToConnectionModel(GetPerson_All());
            ConnectionModel toRemove = new ConnectionModel();

            foreach (ConnectionModel c in connections)
            {
                if (c.FirstPerson.Id == firstPerson.Id && c.SecondPerson.Id == secondPerson.Id)
                {
                    toRemove = c;

                }
                else if (c.FirstPerson.Id == secondPerson.Id && c.SecondPerson.Id == firstPerson.Id)
                {
                    toRemove = c;

                }
            }

            ConnectionModel remove = connections.Single(x => x.Id == toRemove.Id);
            connections.Remove(remove);

            connections.SaveToConnectionFile(ConnectionsFile);


        }

        public void RemovePerson(PersonModel person)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            if (people.Count != 0)
            {
                RemoveTaskByPerson_all(person);
                RemoveConnectionsByPerson_all(person);
                PersonModel remove = people.Single(x => x.Id == person.Id);
                people.Remove(remove);
                people.SaveToPersonFile(PeopleFile);
            }

            
           
        }

        private void RemoveTaskByPerson_all(PersonModel person)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);
            List<TaskModel> output = new List<TaskModel>();

            if (tasks.Count != 0)
            {
                foreach (TaskModel t in tasks)
                {
                    if (t.Person.Id != person.Id)
                    {
                        output.Add(t);
                    }
                }
                output.SaveToTaskFile(TaskListFile);
            }
     


        }

        private void RemoveConnectionsByPerson_all(PersonModel person)
        {
            List<ConnectionModel> connections = ConnectionsFile.FullFilePath().LoadFile().ConvertToConnectionModel(GetPerson_All());
            List<ConnectionModel> output = new List<ConnectionModel>();

            if (connections.Count != 0)
            {
                foreach (ConnectionModel c in connections)
                {
                    if (c.FirstPerson.Id != person.Id && c.SecondPerson.Id != person.Id)
                    {
                        output.Add(c);
                    }
                }
                output.SaveToConnectionFile(ConnectionsFile);
            }
      

        }

        public void RemoveTask(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            if (tasks.Count != 0)
            {
                TaskModel taskToRemove = tasks.Single(x => x.Id == task.Id);
                tasks.Remove(taskToRemove);
                tasks.SaveToTaskFile(TaskListFile);

            }

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
                        t.DateOfCreation = DateTime.Now;
                    }
                    else if (t.Repetition == "monthly")
                    {
                        t.DateOfExecution = t.DateOfExecution.AddMonths(1);
                        t.DateOfCreation = DateTime.Now;
                    }
                    else if (t.Repetition == "quarterly")
                    {
                        t.DateOfExecution = t.DateOfExecution.AddMonths(3);
                        t.DateOfCreation = DateTime.Now;

                    }
                    else if (t.Repetition == "annual")
                    {
                        t.DateOfExecution = t.DateOfExecution.AddYears(1);
                        t.DateOfCreation = DateTime.Now;
                    }
                    else
                    {
                        t.Status = true;
                    }
                    
                }

                tasks.SaveToTaskFile(TaskListFile);
            }
        }

        public string ConverRepetition(string repetition)
        {
            if (repetition == "Brak")
            {
                return "none";
            }
            else if (repetition == "Miesięczna")
            {
                return "monthly";
            }
            else if (repetition == "Kwartalna")
            {
                return "quarterly";
            }
            else if (repetition == "Roczna")
            {
                return "annual";
            }
            else
            {
                return "none";
            }

        }

        public string ReverseConverRepetition(string repetition)
        {
            if (repetition == "none")
            {
                return "Brak";
            }
            else if (repetition == "monthly")
            {
                return "Miesięczna";
            }
            else if (repetition == "quarterly")
            {
                return "Kwartalna";
            }
            else if (repetition == "annual")
            {
                return "Roczna";

            }
            else
            {
                return "Brak";
            }
        }
    }
}
