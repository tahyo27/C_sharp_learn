using Domain.Tests;
using FluentAssertions;

namespace FlightTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var flight = new Flight(seatCapacity: 3); // 1.
            flight.Book("jannick@tutorialeu.com", 1); // 2.
            flight.RemainingNumberOfSeats.Should().Be(2); // 3.
        }
    }
}