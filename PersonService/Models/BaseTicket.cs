using System.Runtime.Serialization;

namespace PersonService.Models
{
    public class BaseTicket
    {
        protected string dateForSerialization;

        public int id { get; set; }

        [OnDeserializing]
        void OnDeserializing(StreamingContext context)
        {
            this.dateForSerialization = "1900-01-01";
        }
    }
}