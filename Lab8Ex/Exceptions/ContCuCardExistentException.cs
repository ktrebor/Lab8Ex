using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Ex.Exceptions
{
    public class ContCuCardExistentException : Exception
    {
        private const string MesajContCuCardExistent = "Cont are deja emis un card";

        public ContCuCardExistentException() : base(MesajContCuCardExistent)
        {
        }
    }
}
