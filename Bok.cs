using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    public class Bok
    {
        public string Titel { get; }
        public string Författare { get; }
        public string ISBN { get; }
        public bool Tillgänglig { get; set; } = true;

        public Bok(string titel, string författare, string isbn)
        {
            Titel = titel;
            Författare = författare;
            ISBN = isbn;
        }
    }
}
