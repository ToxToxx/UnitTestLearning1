using FluentAssertions;
using FluentAssertions.Extensions;
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
       
        private readonly NetworkService _pingService;
        
        public NetworkServiceTests()
        {
            //SUT - System under testing
            _pingService = new NetworkService();
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange

            //Act
            var result = _pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent");
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange

            //Act
            var result = _pingService.PingTimeout(a, b);

            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(3);
            result.Should().NotBeInRange(-10000, 0);
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            //Arrange

            //Act
            var result = _pingService.LastPingDate();

            //Assert
            result.Should().BeAfter(1.January(2023));
            result.Should().BeBefore(1.January(2027));
        }
    }
}
