using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProd
{
    public class FlightReservationSystem :  IEnumerable
    {
        public List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight()
            {
                FlightNumber = "AA254",
                DepartureCity = "Tbilisi",
                ArrivalCity = "Barcelona",
                DepartureTime = new DateTime(2023, 08, 06),
            },
            new Flight()
            {
                FlightNumber = "CC675",
                DepartureCity = "Tbilisi",
                ArrivalCity = "Rome",
                DepartureTime = new DateTime(2023, 08, 06),
            },
            new Flight()
            {
                FlightNumber = "AB555",
                DepartureCity = "Tbilisi",
                ArrivalCity = "Moscow",
                DepartureTime = new DateTime(2023, 08, 07),
            }
        };

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();


        public void ShowFlights()
        {
            foreach (var flight in Flights)
            {
                Console.WriteLine(flight);
            }
        }
        public Flight SearchFlights()
        {

                Console.WriteLine("Please enter some information to find flight: ");
                Console.WriteLine("Departure city: ");
                string departureCity = Console.ReadLine();
                Console.WriteLine("Arrival city: ");
                string arrivalCity = Console.ReadLine();
                Console.WriteLine("Departure time in format DD/MM/YYYY: ");
                DateTime departureTime = DateTime.Parse(Console.ReadLine());
               Flight foundFlight = null;
                for (int i = 0; i < Flights.Count; i++)
                {
                    if (departureCity == Flights[i].DepartureCity && arrivalCity == Flights[i].ArrivalCity && departureTime == Flights[i].DepartureTime)
                    {
                        foundFlight = Flights[i];
                    }

                }
            Console.WriteLine(foundFlight);
            return foundFlight;

        }

        public List<Reservation> BookTicket()
        {
            Console.WriteLine("Press 1 if you want to book ticket");
            Console.WriteLine("Press 0 if you want to quit booking page");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {

                Console.WriteLine("Enter some information for booking ticket: ");
                Console.WriteLine("Enter your name: ");
                string passengerName = Console.ReadLine();
                Console.WriteLine("Enter flight number: ");
                string flightNumber = Console.ReadLine();

                for (int i = 0; i < Flights.Count; i++)
                {
                    if (flightNumber == Flights[i].FlightNumber)
                    {
                        Reservations.Add(new Reservation() { PassengerName = passengerName, ReservationNumber = Reservation.CreateReservationNumber() });
                        Flights[i].AvaliableSeats--;
                    }

                }

                Console.WriteLine("Press 1 if you want to book another ticket, Press 0 if you want to quit the reservation page: ");
                num = int.Parse(Console.ReadLine());
            }

            return Reservations;
        }

        public List<Reservation> CancelReservation()
        {
            Console.WriteLine("To cancel reservation enter your reservation number: ");
            string reservationNumber = Console.ReadLine();

            for (int i = 0; i < Reservations.Count; i++)
            {
                if (reservationNumber == Reservations[i].ReservationNumber)
                {
                    Reservations.Remove(Reservations[i]);
                    Flights[i].AvaliableSeats++;
                }

            }


            return Reservations;
        }

        public void ShowReservations()
        {
            foreach (Reservation reservation in Reservations)
            {
                Console.WriteLine(reservation);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Flights.GetEnumerator();
 
        }

    }
}
