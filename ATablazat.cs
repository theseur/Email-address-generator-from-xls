using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_opening_and_manipulating
{
    class ATablazat
    {
        private string aoszlop;
        private string boszlop;
        private string coszlop;
        private string doszlop;
        private string eoszlop;

        public ATablazat(string aoszlop, string boszlop, string coszlop, string doszlop, string eoszlop)
        {
            this.aoszlop = aoszlop;
            this.boszlop = boszlop;
            this.coszlop = coszlop;
            this.doszlop = doszlop;
            this.eoszlop = eoszlop;
        }

        public string Aoszlop { get => aoszlop; set => aoszlop = value; }
        public string Boszlop { get => boszlop; set => boszlop = value; }
        public string Coszlop { get => coszlop; set => coszlop = value; }
        public string Doszlop { get => doszlop; set => doszlop = value; }
        public string Eoszlop { get => eoszlop; set => eoszlop = value; }
    }

}
