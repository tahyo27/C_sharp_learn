﻿using System.Security.Cryptography.X509Certificates;

namespace Domain
{
    public class Flight
    {

        List<Booking> bookingList = new();
        public IEnumerable<Booking> BookingList => bookingList;
       // public List<Booking> BookingList { get; set; } = new List<Booking>();

        public int RemainingNumberOfSeats { get; set; }
        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public object? Book(string passengerEmail, int numberOfSeats)
        {
            // 에러까지 테스트
            if (numberOfSeats > this.RemainingNumberOfSeats)
            {
                return new OverbookingError();
            }
            RemainingNumberOfSeats -= numberOfSeats;

            bookingList.Add(new Booking(passengerEmail, numberOfSeats));

            return null;
            //return new OverbookingError();
        }

    }
}
