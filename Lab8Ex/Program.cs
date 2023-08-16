using Lab8Ex.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lab8Ex
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
 
            var banca = new Banca();
            
            var cardBancar = banca.CreeazaCont();
            var cardBancar2 = banca.CreeazaCont();

            banca.EmiteCard(cardBancar);
            banca.AcceptaPlata(100, cardBancar);
            banca.Plateste(50, cardBancar);
            

       

            //banca.Plateste(100, cardBancar);

            //banca.AdaugaCont(card);

           /*
            //depunere bani
            try
            {
                card.DepuneNumerar(100);
            }
            catch (OpereazaSumaNegativaException e)
            {
                Console.WriteLine(e);
            }

            //extragere bani
            try
            {
                card.ExtrageNumerar(1);
            } 
            catch (FonduriInsuficienteException e)
            {
                Console.WriteLine(e);
            }
            catch (OpereazaSumaNegativaException e)
            {
                Console.WriteLine(e);
            }
           */
        }
    }
}
