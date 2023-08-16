using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Ex.Exceptions
{
    public class ContInexistentException : Exception
    {
        private const string MesajContInexistent = "Cont Inexistent!";

        public ContInexistentException() : base(MesajContInexistent)
        {
        }
    }
}
