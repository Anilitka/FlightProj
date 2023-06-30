using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FlightProd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlightReservationSystem frs = new FlightReservationSystem();
            bool start = true;
            while (start)
            {
                try
                {
                    Console.WriteLine("1.All Flight\n2.Search\n3.Book\n4.Cancel\n5.ShowReservation");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            frs.ShowFlights();
                            break;
                        case "2":
                            frs.SearchFlights();
                            break;
                        case "3":
                            Console.WriteLine("Enter Flight Number");
                            string flightNumber = Console.ReadLine();
                            Console.WriteLine("Enter Passenger Name");
                            string passengerName = Console.ReadLine();
                            
                            frs.BookTicket();
                            break;
                        case "4":
                            Console.WriteLine("Enter Reservation Number");
                            string reservationNumber = Console.ReadLine();
                            frs.CancelReservation();
                            break;
                        case "5":
                            frs.ShowReservations();
                            break;
                        default:
                            start = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Woops! Something went wrong! Try again!");
                }
            }


        }
    

    }
}
