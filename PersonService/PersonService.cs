using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json;
using PersonService.BulkLoad;
using PersonService.Core;
using PersonService.Logs;
using PersonService.Models;
using PersonService.Models.Context;
using PersonService.Models.Requests;

namespace PersonService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PersonService : IPersonService
    {
        [WebGet(UriTemplate = "/Person?id={id}", ResponseFormat = WebMessageFormat.Json)]
        public string GetPerson(int id)
        {
            Person peep = people.SingleOrDefault(p => p.Id == id);
            string json = JsonConvert.SerializeObject(peep);

            return json;
        }

        [WebInvoke(UriTemplate = "Person", RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        public Person InsertPerson(Person[] person)
        {
            return people[2];
        }

        [WebInvoke(UriTemplate = "/Person?id={id}", Method = "PUT")]
        public Person UpdatePerson(int id, Person person)
        {
            return people[1];
        }

        [WebInvoke(UriTemplate = "/Person?id={id}", Method = "DELETE")]
        public void DeletePerson(int id)
        {
        }

        private static void WriteLog(string message)
        {
            using (StreamWriter log = File.AppendText("logs/log.txt"))
            {
                log.Write(DateTime.Now.ToString(CultureInfo.InvariantCulture) + ": " + message + "\r\n");
                log.Flush();
                log.Close();
            }
        }

        #region private objects
        private Person[] people = new Person[]
            {
                new Person
                    {
                        Id = 1,
                        FirstName = "Biff",
                        LastName = "McGillicutty"
                    },
                new Person
                    {
                        Id = 2,
                        FirstName = "Muffy",
                        LastName = "McSplit"
                    },
                new Person
                    {
                        Id = 3,
                        FirstName = "Stan",
                        LastName = "Standard"
                    }
            };

        #endregion private objects

    }
}