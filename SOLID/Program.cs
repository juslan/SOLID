using SOLID.TipoSocio;
using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Hercules socio1 = new Hercules(500)
            {
                Name = "Carlos Perez",
                Ci=465454,
                Tribuna="Curva Sur",
                YearRemainingSocio=2021
            };
            HerculesAvidor socio2 = new HerculesAvidor(1000)
            {
                Name = "Jose Mendez",
                Ci = 12345945,
                Tribuna = "General",
                YearRemainingSocio = 2021
            };
            MagnateAviador socio3 = new MagnateAviador(1500)
            {
                Name = "Juslan Vargas",
                Ci = 6415292,
                Tribuna = "Preferencia",
                YearRemainingSocio = 2022
            };
            socio1.SumarySocio();
            socio1.SubscribeNextYear();
            socio1.CongratsSocio();
            Console.WriteLine($"Su compra tiene un valor de: 200, aplicando descuento tendra un costo de: {socio1.PurchaseInStore(200)}");
            Console.WriteLine("-------------------------");
            socio2.SumarySocio();
            socio2.SubscribeNextYear();
            socio2.CongratsSocio();
            Console.WriteLine($"Su compra tiene un valor de: 200, aplicando descuento tendra un costo de: {socio2.PurchaseInStore(200)}");
            Console.WriteLine("-------------------------");
            socio3.SumarySocio();
            socio3.SubscribeNextYear();
            socio3.CongratsSocio();
            Console.WriteLine($"Su compra tiene un valor de: 200, aplicando descuento tendra un costo de: {socio3.PurchaseInStore(200)}");

        }
    }
}
