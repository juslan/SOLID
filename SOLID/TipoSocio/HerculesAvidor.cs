using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.TipoSocio
{
    class HerculesAvidor : Socio, ISocio
    {
        private decimal price;
        private int descuentoPorcentual = 15;

        public HerculesAvidor(decimal due)
        {
            price = 1000;
        }
        public void CongratsSocio()
        {
            Console.WriteLine($"Gracias por estar con nosotros {Name}");
        }

        public decimal PurchaseInStore(int price)
        {
            decimal totalDiscount = price * descuentoPorcentual / 100;
            return price - totalDiscount;
        }

        public void SubscribeNextYear()
        {
            YearRemainingSocio++;
            Console.WriteLine("Gracias por estar con nosotros un año mas HerculesAviador");
        }
        public void SumarySocio()
        {
            Console.WriteLine($"El socio {Name} con CI: {Ci} tiene/tenia hasta {YearRemainingSocio} apoyando al Wilster desde la tribuna de {Tribuna}");
        }
    }
}
