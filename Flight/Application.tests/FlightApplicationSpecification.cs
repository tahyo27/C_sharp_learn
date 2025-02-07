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
        [Theory]
        [InlineData("M@m.cpom", 2)]
        [InlineData("a@a.com", 2)]
        public void Books_flight(string passengerEmail, int numberOfSeats)
        {
            var entities = new Entities(new DbContextOptionsBuilder<Entities>()
                .UseInMemoryDatabase("Flights")
                .Options
                );
            var flight = new Flight(3);
            entities.Flights.Add(flight);

            var bookingService = new BookingService(entities: entities);

            bookingService.Book(new BookDto(
                flightId: flight.Id, passengerEmail, numberOfSeats));

            bookingService.FindBookings(flight.Id).Should().ContainEquivalentOf(
                new BookingRm(passengerEmail, numberOfSeats)
                );
        }
    }
}


