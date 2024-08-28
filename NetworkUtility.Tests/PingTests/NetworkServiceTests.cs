using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent");
            result.Should().Contain("Success", Exactly.Once());

        }
    }
}
