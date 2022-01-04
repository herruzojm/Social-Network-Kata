using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Users
{
    public class User
    {
        public string UserName { get; }

        public User(string userName)
        {
            UserName = userName;
        }

    }
}
