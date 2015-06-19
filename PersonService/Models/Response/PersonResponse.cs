using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PersonService.Models.Response
{
    public sealed class PersonResponse : BaseResponseData
    {
        [JsonProperty(PropertyName = "Tickets")]
        public IList<Person> Persons;
    }
}