﻿using System.Security.Cryptography.X509Certificates;

namespace Domain
{
    public class Flight
    {
        public int RemainingNumberOfSeats { get; set; }
        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public void Book(string passengerEmail, int numberOfSeats)
        {
            RemainingNumberOfSeats -= numberOfSeats;
        }

    }
}
