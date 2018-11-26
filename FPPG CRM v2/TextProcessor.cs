using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_CRM_v2
{
    public static class TextProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ GlobalConfig.myDir }\\{ fileName } ";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();

            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Address = cols[3];
                p.PhoneNumber = cols[4];
                p.EmailAddress = cols[5];
                p.PersonalIdNumber = cols[6];
                p.PESEL = cols[7];
                p.Note = cols[8];
                p.RODO = bool.Parse(cols[9]);
                p.RodoDate = DateTime.Parse(cols[10]);

                output.Add(p);

            }

            return output;

        }

        public static List<TaskModel> ConvertToTaskModels(this List<string> lines, string peopleFileName)
        {
            List<TaskModel> output = new List<TaskModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');
                TaskModel t = new TaskModel();

                t.Id = int.Parse(cols[0]);
                t.Category = cols[1];
                t.DateOfCreation = DateTime.Parse(cols[2]);
                t.DateOfExecution = DateTime.Parse(cols[3]);
                t.Note = cols[4];
                t.Status = bool.Parse(cols[5]);
                t.Repetition = cols[6];

                int personId = int.Parse(cols[7]);

                foreach (PersonModel p in people)
                {
                    if (p.Id == personId)
                    {
                        t.Person = p;
                    }
                }

                output.Add(t);

            }
            return output;

        }

        public static List<ConnectionModel> ConvertToConnectionModel(this List<string> lines, List<PersonModel> people)
        {
            
            List<ConnectionModel> output = new List<ConnectionModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                ConnectionModel c = new ConnectionModel();


                c.Id = int.Parse(cols[0]);
                int firstId = int.Parse(cols[1]);
                int secondId = int.Parse(cols[2]);

               foreach (PersonModel p  in people)
                {
                    if (p.Id == firstId)
                    {
                        c.FirstPerson = p;
                    }
                    else if (p.Id == secondId)
                    {
                        c.SecondPerson = p;
                    }
          
                }

                output.Add(c);

            }
            return output;

        }

        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id }#{ p.FirstName }#{ p.LastName }#{ p.Address }#{ p.PhoneNumber}#{ p.EmailAddress }#{ p.PersonalIdNumber }#{ p.PESEL }#{ p.Note }#{p.RODO}#{p.RodoDate}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTaskFile(this List<TaskModel> tasks, string fileName)
        {

            List<string> lines = new List<string>();

            foreach (TaskModel t in tasks)
            {
                lines.Add($"{ t.Id }#{ t.Category }#{ t.DateOfCreation }#{ t.DateOfExecution }#{ t.Note }#{ t.Status }#{ t.Repetition }#{ t.Person.Id }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToConnectionFile(this List<ConnectionModel> connections, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (ConnectionModel c in connections)
            {
                lines.Add($"{ c.Id }#{ c.FirstPerson.Id }#{ c.SecondPerson.Id }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);

        }


    }
}
