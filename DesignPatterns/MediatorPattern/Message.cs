using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    public class Message
    {
        public Message(string body, Person sentTo = null)
        {
            Body = body;
            SentTo = sentTo;
        }

        public string Body { get; set; }
        public Person SentTo { get; set; }
    }

}
