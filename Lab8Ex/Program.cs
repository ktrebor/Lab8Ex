using Lab8Ex.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lab8Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card = new ContBancar();

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
        }
    }
}
