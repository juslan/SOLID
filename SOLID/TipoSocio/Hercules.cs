using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.TipoSocio
{
    class Hercules : SocioAviador, ISocio
    {
        private decimal _price;
        private int descuentoPorcentual = 5;

        public Hercules(decimal price)
        {
            _price = price;
        }

        public void CongratsSocio()
        {
            Console.WriteLine($"Gracias por estar con nosotros {Name}");
        }

        public decimal PurchaseInStore(int price)
        {
            return price - (price * (descuentoPorcentual / 100));
        }

        public void SubscribeNextYear()
        {
            YearRemainingSocio++;
            Console.WriteLine("Gracias por estar con nosotros un año mas Hercules");
        }

        public void SumarySocio()
        {
            Console.WriteLine($"El socio {Name} con CI: {Ci} tiene/tenia hasta {YearRemainingSocio} apoyando al Wilster desde la tribuna de {Tribuna}");
        }
    }
}
