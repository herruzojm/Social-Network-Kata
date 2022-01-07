using SocialNetwork.Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Repository.Users
{
    public interface IUserRepository
    {
        void AddUser(User user);

        User GetUser(string userName);
    }
}
