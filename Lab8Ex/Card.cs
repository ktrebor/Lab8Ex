using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Ex
{
    public class Card
    {
        public Guid idCard { get; set; }

        public Card()
        {
        }
        
        public void IntroduCard()
        {
            Console.WriteLine("Introdu cardul");
        }

        public Guid GetCardData(ContBancar cont)
        {
            return cont.Id;
        }

        public void ExtrageCard()
        {
            Console.WriteLine("Scoate cardul");
        }
    }
}
