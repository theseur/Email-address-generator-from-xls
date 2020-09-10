using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_opening_and_manipulating
{
    class ATablazatlista
    {
        List<ATablazat> lista;

        public ATablazatlista(string a, string b, string c, string d, string e)
        {
            lista = new List<ATablazat>();
            lista.Add(new ATablazat(a, b, c, d, e));
        }
             public ATablazat this[int index]
        {
            get
            {
                return lista[index];
            }
        }
    }
       
    
}
