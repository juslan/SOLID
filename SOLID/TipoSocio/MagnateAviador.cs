﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.TipoSocio
{
    class MagnateAviador:SocioAviador,ISocio
    {
        private decimal price;
        private int descuentoPorcentual = 25;

        public MagnateAviador(decimal due)
        {
            price = 1500;
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
            Console.WriteLine("Gracias por estar con nosotros un año mas HerculesAviador");
        }
        public void SumarySocio()
        {
            Console.WriteLine($"El socio {Name} con CI: {Ci} tiene/tenia hasta {YearRemainingSocio} apoyando al Wilster desde la tribuna de {Tribuna}");
        }
    }
}
