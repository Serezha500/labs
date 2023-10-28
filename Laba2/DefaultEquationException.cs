using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class DefaultEquationException : Exception
    {
        public override string Message
        {
            get
            {
                return "Коэффициент a=0";
            }
        }
    }
}
