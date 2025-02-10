using System.Reflection.Metadata;
using FluentAssertions;
using Xunit.Sdk;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using Application.tests;

namespace Application.tests

{
    
    public class FlightApplicationSpecification
    {
        readonly Entities entities = new Entities(new DbContextOptionsBuilder<Entities>()
                .UseInMemoryDatabase("Flights")
                .Options
                );
        readonly BookingService bookingService;

        public FlightApplicationSpecification()
        {
            bookingService = new BookingService(entities: entities);
        }

        [Theory]
        [InlineData("M@m.cpom", 2)]
        [InlineData("a@a.com", 2)]
        public void Remembers_bookings(string passengerEmail, int numberOfSeats)
        {
            var flight = new Flight(3);
            entities.Flights.Add(flight);


            bookingService.Book(new BookDto(
                flightId: flight.Id, passengerEmail, numberOfSeats));

            bookingService.FindBookings(flight.Id).Should().ContainEquivalentOf(
                new BookingRm(passengerEmail, numberOfSeats)
                );
        }

        [Theory]
        [InlineData(3)]
        [InlineData(10)]
        public void Frees_up_seats_after_booking(int initialCapacity)
        {
            //given
            var flight = new Flight(initialCapacity);
            entities.Flights.Add(flight);

            bookingService.Book(new BookDto(flightId: flight.Id,
                passengerEmail: "m@m.com",
                numberOfSeats: 2
                ));
            //when
            bookingService.CancelBooking(
                new CancelBookingDto(flightId: flight.Id,
                passengerEmail: "m@m.com",
                numberOfSeats: 2)
                );
            //then
            bookingService.GetRmainingNumberOfSeatsFor(flight.Id).Should().Be(initialCapacity);
        }
    }

}


