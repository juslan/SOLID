using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public abstract class SocioAviador
    {
        public int Ci { get; set; }
        public string Name { get; set; }
        public int YearRemainingSocio { get; set; }
        public string Tribuna { get; set; }
    }
}
