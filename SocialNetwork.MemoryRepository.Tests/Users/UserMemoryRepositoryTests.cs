using FluentAssertions;
using SocialNetwork.Domain.Model.Users;
using SocialNetwork.Domain.Repository.Users;
using SocialNetwork.MemoryRepository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SocialNetwork.MemoryRepository.Tests.Users
{
    public class UserMemoryRepository_Should
    {
        private readonly IUserRepository _userRepository;
        private readonly string _userName1 = "userName1";
        private readonly string _userName2 = "userName2";

        public UserMemoryRepository_Should()
        {
            _userRepository = new UserMemoryRepository();
        }

        [Fact]
        public void Add_User()
        {
            User user = new User(_userName1);
            _userRepository.AddUser(user);

            var recoveredUser = _userRepository.GetUser(_userName1);
            recoveredUser.Should().NotBeNull();
            recoveredUser.UserName.Should().Be(_userName1);
        }

        [Fact]
        public void Get_User()
        {
            User user1 = new User(_userName1);
            User user2 = new User(_userName2);
            _userRepository.AddUser(user1);
            _userRepository.AddUser(user2);

            var recoveredUser = _userRepository.GetUser(_userName2);
            recoveredUser.Should().NotBeNull();
            recoveredUser.UserName.Should().Be(_userName2);
        }

        [Fact]
        public void Return_Null_Getting_Not_Existing_User()
        {
            var recoveredUser = _userRepository.GetUser(_userName1);
            recoveredUser.Should().BeNull();
        }
    }
}
