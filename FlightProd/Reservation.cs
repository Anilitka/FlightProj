using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProd
{
    public class Reservation 
    {
        public string ReservationNumber { get; set; }
        public string PassengerName { get; set; }
        public Flight Flight { get; set; }


        public Reservation()
        {
            ReservationNumber = CreateReservationNumber();
        }
        static Random random = new Random();

        public static string CreateReservationNumber()
        {
            int char1 = random.Next(65, 90);
            char mychar1 = Convert.ToChar(char1);

            int char2 = random.Next(65, 90);
            char mychar2 = Convert.ToChar(char2);

            int num1 = random.Next(0, 9);
            int num2 = random.Next(0, 9);

            return $"{mychar1}{mychar2}{num1}{num2}";

        }
        public override string ToString()
        {
            return base.ToString() + $"Reservation number {ReservationNumber}, Passanger name {PassengerName}";
        }


    }
}
