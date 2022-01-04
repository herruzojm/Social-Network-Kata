using SocialNetwork.Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Messages
{
    public class MessageValidator
    {
        public bool IsValid(Message message)
        {
            if (message.Text.Trim() == string.Empty)
            {
                return false;
            }

            var userValidator = new UserValidator();
            if (!userValidator.IsValid(message.UserName))
            {
                return false;
            }

            return true;
        }
    }
}
