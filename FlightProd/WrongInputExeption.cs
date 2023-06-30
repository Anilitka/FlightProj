using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProd
{
    internal class WrongInputExeption : ApplicationException
    {
        private string _message;
        public WrongInputExeption()
        {
            _message = "Wrong input! Please try correct format";
        }
        public override string Message { get { return _message; } }
    }
}
