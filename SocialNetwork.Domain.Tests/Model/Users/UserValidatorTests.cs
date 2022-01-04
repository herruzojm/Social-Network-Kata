using FluentAssertions;
using SocialNetwork.Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SocialNetwork.Domain.Tests.Model.Users
{
    public class UserValidator_Should
    {
        private readonly UserValidator _userValidator = new();

        [Fact]
        public void Not_Allow_Empty_Names()
        {
            _userValidator.IsValid(string.Empty).Should().BeFalse();
        }

        [Fact]
        public void Not_Allow_Names_With_Whitespaces()
        {
            _userValidator.IsValid("wrong name").Should().BeFalse();
        }

        [Fact]
        public void Allow_Valid_Names()
        {
            _userValidator.IsValid("user_name").Should().BeTrue();
        }

        [Fact]
        public void Allow_Validate_Users()
        {
            User user = new User("user_name");
            _userValidator.IsValid(user).Should().BeTrue();
        }
    }
}
