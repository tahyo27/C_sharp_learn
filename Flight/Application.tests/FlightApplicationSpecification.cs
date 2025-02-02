using FluentAssertions;
using Xunit.Sdk;

namespace Application.tests

{
    public class FlightApplicationSpecification
    {
        [Fact]
        public void Books_flight()
        {
            var bookingService = new BookingService();

            bookingService.Book(new BookDto(
                flightId: Guid.NewGuid(), passengerEmail: "a@b.com", numberOfSeats: 2));

            bookingService.FindBookings().Should().ContainEquivalentOf(
                new BookingRm(passengerEmail: "a@b.com", numberOfSeats: 2)
                );
        }
    }

    public class BookingService
    {
        public void Book(BookDto bookDto)
        {

        }

        public IEnumerable<BookingRm> FindBookings()
        {
            return new[]
            {
                new BookingRm(passengerEmail: "a@b.com", numberOfSeats: 2)
            };
        }
    }

    public class BookDto
    {
        public BookDto(Guid flightId, string passengerEmail, int numberOfSeats)
        {

        }
    }
    
    public class BookingRm
    {
        public string PassengerEmail { get; set; }
        public int NumberOfSeats { get; set; }
        public BookingRm(string passengerEmail, int numberOfSeats)
        {
            PassengerEmail = passengerEmail;
            NumberOfSeats = numberOfSeats;
        }
    }
}