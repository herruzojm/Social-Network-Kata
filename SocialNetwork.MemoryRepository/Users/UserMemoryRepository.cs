using SocialNetwork.Domain.Model.Users;
using SocialNetwork.Domain.Repository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.MemoryRepository.Users
{
    public class UserMemoryRepository : IUserRepository
    {
        private readonly Dictionary<string, User> _users = new(); 

        public void AddUser(User user)
        {
            if (!_users.ContainsKey(user.UserName)){
                _users.Add(user.UserName, user);
            }
        }

        public User GetUser(string userName)
        {
            return _users.GetValueOrDefault(userName);
        }
    }
}
