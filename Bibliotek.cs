using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    public class Bibliotek
    {
        public string Namn { get; }
        public string Adress { get; }
        public List<Bok> Böcker { get; } = new List<Bok>();
        public List<Medlem> Medlemmar { get; } = new List<Medlem>();

        public Bibliotek(string namn, string adress)
        {
            Namn = namn;
            Adress = adress;
        }
    }
}
