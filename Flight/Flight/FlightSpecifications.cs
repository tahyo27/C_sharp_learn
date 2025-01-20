using Domain;
using FluentAssertions;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3); // 1.
            flight.Book("jannick@tutorialeu.com", 1); // 2.
            flight.RemainingNumberOfSeats.Should().Be(2); // 3.
        }
    }
}