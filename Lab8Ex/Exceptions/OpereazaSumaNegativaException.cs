using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Ex.Exceptions
{
    public class OpereazaSumaNegativaException : Exception
    {
        private const string MesajSumaNegativa = "Suma trebuie să fie pozitivă";

        public OpereazaSumaNegativaException() : base(MesajSumaNegativa)
        {
        }
    }
}
