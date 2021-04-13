using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class EquipoFutbol
    {
        public string TeamName { get; set; }
        public int YearFoundation { get; set; }
        public string Country { get; set; }
        public string Departure { get; set; }
        public List<SocioAviador> Socios { get; set; }
    }
}
