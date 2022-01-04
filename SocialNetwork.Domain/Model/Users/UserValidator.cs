using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Users
{
    public class UserValidator
    {
        public bool IsValid(User user)
        {
            return IsValid(user.UserName);
        }

        public bool IsValid(string userName)
        {
            // no empty names
            // no spaces in the name
            if (userName.Length == 0)
            {
                return false;
            }

            if (userName.Any(Char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }
    }
}
