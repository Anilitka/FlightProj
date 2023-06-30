using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProd
{
    public class Flight 
    {
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public int AvaliableSeats { get; set; } = 50;



        public override string ToString()
        {
            return $"Flight number {FlightNumber}, Departure City {DepartureCity}, Arrival City {ArrivalCity}, Departure Time {DepartureTime}, Avaliable Seats {AvaliableSeats} ";
        }
    }
}
