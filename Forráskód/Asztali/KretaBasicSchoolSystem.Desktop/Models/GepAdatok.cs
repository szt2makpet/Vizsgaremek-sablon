using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.Models
{
    public class GepAdatok
    {
        public string Gepneve { get; set; }
        public int Foglaltturista { get; set; }
        public int Foglalt1oszt { get; set; }
        public int Elsoosztulohelyek { get; set; }
        public int Turistaulohelyek { get; set; }

        public GepAdatok(string gepneve, int foglaltturista, int foglalt1oszt, int elsoosztulohelyek, int turistaulohelyek)
        {
            Gepneve = gepneve;
            Foglaltturista = foglaltturista;
            Foglalt1oszt = foglalt1oszt;
            Elsoosztulohelyek = elsoosztulohelyek;
            Turistaulohelyek = turistaulohelyek;
        }

        public GepAdatok()
        {
            Gepneve = string.Empty;
            Foglaltturista = 0;
            Foglalt1oszt = 0;
            Elsoosztulohelyek = 1;
            Turistaulohelyek = 1;
        }

        public override string ToString()
        {
            return $"{Gepneve} {Foglaltturista} {Foglalt1oszt} {Elsoosztulohelyek} {Turistaulohelyek}";
        }


    }
}
