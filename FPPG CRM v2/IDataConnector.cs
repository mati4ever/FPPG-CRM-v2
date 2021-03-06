﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_CRM_v2
{
    public interface IDataConnector
    {
        void CreatePerson(PersonModel person);
        void CreateTask(TaskModel task);
        void CreateConnection(ConnectionModel connection);

        List<PersonModel> GetPerson_All();
        List<TaskModel> GetTask_All();
        List<TaskModel> GetTask_Active();
        List<TaskModel> GetTaks_Today();
        List<TaskModel> GetTask_Close();
        List<TaskModel> GetTask_Missed();

        List<PersonModel> GetConnectionsByPerson_All(PersonModel person);
        List<PersonModel> AvaliableConnections(PersonModel person);

        List<TaskModel> GetTaskByPerson_All(PersonModel person);
        List<TaskModel> GetTaskByPerson_Active(PersonModel person);

        void TaskDelay(TaskModel task);
        void TaskDone(TaskModel task);

        void SaveEditedTask(TaskModel task);
        void SaveEditedPerson(PersonModel person);

        void RemoveTask(TaskModel task);
        void RemovePerson(PersonModel person);
        void RemoveConnection(PersonModel firstPerson, PersonModel secondPerson);

        int GetPersonId();
        List<string> GetTaskCategory();

        string ConverRepetition(string repetition);
        string ReverseConverRepetition(string repetition);

        string ConvertNote(string note);
        string LoadNote(string note);

    }
}
    