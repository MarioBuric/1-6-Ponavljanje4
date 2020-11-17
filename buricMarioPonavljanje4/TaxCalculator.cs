using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricMarioPonavljanje4
{
    class TaxCalculator
    {
        private static decimal _cijenaproizvoda;
        private static decimal _postotakPDV;
        private static decimal _ukupnacijena;

        public TaxCalculator(string inputcijenaproizvoda, string inputpostotakPDV)
        {
            _cijenaproizvoda = Decimal.Parse(inputcijenaproizvoda);
            _postotakPDV = Decimal.Parse(inputpostotakPDV) / 100;
        }

        public void CalculateTotalPrice()
        {
            _ukupnacijena = _cijenaproizvoda + (_cijenaproizvoda * _postotakPDV);
        }

        public void GetTotalMsg()
        {
         Console.WriteLine("Cijena proizvoda je {0:C} i ukupna cijena je {1:C} na postotku PDV-a od {2:p0}", _cijenaproizvoda, _ukupnacijena, _postotakPDV);
        }
    }
}
