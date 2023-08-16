using Lab8Ex.Exceptions;
using System;
using System.Collections.Generic;

namespace Lab8Ex
{
    public class Banca
    {
        private readonly Dictionary<Guid, ContBancar> listaConturi = new();
        private readonly Dictionary<Guid, Card> listaCarduri = new();

        public Banca()
        {
            listaConturi = new Dictionary<Guid, ContBancar>();
        }

        public Guid CreeazaCont()
        {
            var cont = new ContBancar();
            AdaugaCont(cont);
            return cont.Id;   
        }

        public void AdaugaCont(ContBancar cont)
        {
            listaConturi.Add(cont.Id, cont);
        }

        public void EmiteCard(Guid idCont)
        {
            if (!listaConturi.ContainsKey(idCont))
            {
                throw new ContInexistentException();
            }
            else if (listaCarduri.ContainsKey(idCont))
            {
                throw new ContCuCardExistentException();
            }
            else  
            {
                Card card = new Card();
                card.idCard = idCont;
                listaCarduri.Add(card.idCard, card);
            }                  
        }

        public void AcceptaPlata(decimal suma, Guid idCont)
        {
            if (!listaConturi.ContainsKey(idCont))
            {
                throw new ContInexistentException();
            }

            else
            {
                ContBancar cont = listaConturi[idCont];
                cont.DepuneNumerar(suma);
            }
        }

        public void Plateste(decimal suma, Guid idCont)
        {
            if (!listaConturi.ContainsKey(idCont))
            {
                throw new ContInexistentException();
            } 

            else
            {
                ContBancar cont = listaConturi[idCont];
                cont.ExtrageNumerar(suma);
            }
        }
    }   
}
