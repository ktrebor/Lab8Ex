using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Ex.Exceptions
{
    public class FonduriInsuficienteException : Exception
    {
        private const string MesajFonduriInsuficiente = "Fonduri insuficiente";

        public FonduriInsuficienteException() : base(MesajFonduriInsuficiente)
        {
        }
    }
}
