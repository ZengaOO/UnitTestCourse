using ConsoleUtilite.Ping;
using FluentAssertions;
using FluentAssertions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilite.Test.PingTest
{
    public class ConsoleServiceTest
    {
        private readonly ConsoleService _pingService;
        public ConsoleServiceTest()
        {
            //SUT
            //Depdencies
            _pingService = new ConsoleService();
        }
        [Fact]
        public void ConsoleService_SendPing_ReturnString()
        {
            //Arrange - variables,classes, mocks
            var pingService = new ConsoleService();

            //Act
            var result = pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Send");
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
        [InlineData(1, 1, 2)]//int a =1, int b = 1, expected = 2;
        [InlineData(2, 2, 4)]
        public void ConsoleService_PingTimequit_ReturnInt(int a, int b, int expected)
        {
            //Arrange 
            var pingService = new ConsoleService();
            //Act
            var result = pingService.PingTimequit(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-10000, 0);
        }

        [Fact]
        public void ConsoleService_LastPingDate_ReturnDate()
        {
            //Arrange - variables,classes, mocks
            var pingService = new ConsoleService();

            //Act
            var result = pingService.LastPingDate();

            //Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));

        }
        [Fact]//test return object
        public void ConsoleService_GetPingOptions_ReturnsObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                //object
                DontFragment = true,
                Ttl = 1
            };
            //Act
            var result = _pingService.GetPingOptions();
            //Assert WARNING: "Be" careful
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);//(expected.Ttl);
        }
        [Fact]//test return collection
        public void ConsoleService_MostRecentPings_ReturnsObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                //object
                DontFragment = true,
                Ttl = 1
            };
            //Act
            var result = _pingService.MostRecentPings();
            //Assert WARNING: "Be" careful
           // result.Should().BeOfType<IEnumerable<PingOptions>>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);
        }

    }

}
