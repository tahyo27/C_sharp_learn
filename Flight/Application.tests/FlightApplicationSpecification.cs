using FluentAssertions;

namespace Application.tests

{
    public class FlightApplicationSpecification
    {
        [Fact]
        public void Books_flight()
        {
            var bookingService = new BookingService();
            bookingService.Book(new BookDto());
            bookingService.FindBookings().Should().ContainEquivalentOf(
                new BookingRm()
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
            throw new NotImplementedException();
        }
    }

    public class BookDto
    {

    }
    
    public class BookingRm
    {

    }
}