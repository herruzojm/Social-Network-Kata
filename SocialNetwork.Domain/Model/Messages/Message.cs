using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Messages
{
    public class Message
    {
        public string UserName { get; }

        public DateTime CreationTime { get; }

        public string Text { get; }

        public Message(string userName, string text)
        {
            UserName = userName;
            Text = text;
            CreationTime = DateTime.Now;
        }

        public override string ToString()
        {
            return Text;
        }
    }

}
