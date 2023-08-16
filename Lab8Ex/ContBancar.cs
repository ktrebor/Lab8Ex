using Lab8Ex.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Ex
{
    public class ContBancar
    {
        public Guid Id { get; }
        public decimal Sold { get; set;}
        
        public ContBancar()
        {
            Id = Guid.NewGuid();
            Sold = 0;
        }

        public void DepuneNumerar(decimal suma)
        {
            if (suma <= 0)
            {
                throw new OpereazaSumaNegativaException();
            } 
            else
            {
                Sold += suma; 
            }
        }

        public void ExtrageNumerar(decimal suma)
        {
            if (suma <= 0)
            {
                throw new OpereazaSumaNegativaException();
            }
            else if (suma > Sold)
            {
                throw new FonduriInsuficienteException();
            }
            else
            {
                Sold -= suma;
            }
        }
    }
}
