using FluentAssertions;
using SocialNetwork.Domain.Model.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SocialNetwork.Domain.Tests.Model.Messages
{
    public class MessageValidator_Should
    {
        private readonly MessageValidator _messageValidator = new ();
        private readonly string _messageText = "text";
        private readonly string _userName = "username";

        [Fact]
        public void Not_Allow_Messages_With_Empty_Text()
        {
            var message = new Message(_userName, string.Empty);
            _messageValidator.IsValid(message).Should().BeFalse();
        }

        [Fact]
        public void Not_Allow_Messages_With_Invalid_UserName()
        {
            var message = new Message(string.Empty, _messageText);
            _messageValidator.IsValid(message).Should().BeFalse();
        }

        [Fact]
        public void Allow_Valid_Messages()
        {
            var message = new Message(_userName, _messageText);
            _messageValidator.IsValid(message).Should().BeTrue();
        }
    }
}
