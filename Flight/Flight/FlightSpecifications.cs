using Domain;
using FluentAssertions;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Theory] // �Ϻ� �����Ͱ� �޼��� �ܺο��� �´�
        [InlineData(3, 1, 2)] // �ζ��ε����Ͱ� ����� ����
        [InlineData(6, 3, 3)]
        [InlineData(10, 6, 4)]
        public void Booking_reduces_the_number_of_seats(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
        {
            var flight = new Flight(seatCapacity: seatCapacity); // 1.
            flight.Book("jannick@tutorialeu.com", numberOfSeats); // 2.
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats); // 3.
        }

        //[Fact]
        //public void Booking_reduces_the_number_of_seats_2()
        //{
        //    var flight = new Flight(seatCapacity: 6); // 1.
        //    flight.Book("jannick@tutorialeu.com", 3); // 2.
        //    flight.RemainingNumberOfSeats.Should().Be(3); // 3.
        //}
        //// �پ��� ���� �׽�Ʈ �غ��°� ����

        //public void Booking_reduces_the_number_of_seats_3()
        //{
        //    var flight = new Flight(seatCapacity: 10); // 1.
        //    flight.Book("jannick@tutorialeu.com", 6); // 2.
        //    flight.RemainingNumberOfSeats.Should().Be(4); // 3.
        //}
        [Fact]
        public void Avoids_overbooking()
        {
            // Given
            var flight = new Flight(seatCapacity: 3);

            // When
            var error = flight.Book("jannick@tutorialseu.com", 4);

            // Then
            error.Should().BeOfType<OverbookingError>();
        }

        [Fact]
        public void Books_flight_successfully()
        {
            var flight = new Flight(seatCapacity: 3);
            var error = flight.Book("jannick@tutorialseu.com", 1);
            error.Should().BeNull();
        }
    }
}