using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_3.Model
{
    internal class Materijal
    {
        public class Materijal
        {
            public int Id_materijala { get; set; }
            public string Ime_materijala { get; set; }

            public string Vrsta_materijala { get; set; }

            public string Cijena { get; set; }

            public override string ToString()
            {
                return Vrsta_materijala != "" ? Vrsta_materijala : Ime_materijala;
            }
        }
    }
}
}
