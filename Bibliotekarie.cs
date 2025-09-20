using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    public class Bibliotekarie : Person
    {
        public int PersonalID { get; }

        public Bibliotekarie(int personalID, string namn, string epost)
            : base(namn, epost)
        {
            PersonalID = personalID;
        }

        public void RegistreraBok(Bibliotek bibliotek, Bok bok)
        {
            bibliotek.Böcker.Add(bok);
            Console.WriteLine($"Bok '{bok.Titel}' registrerad av {Namn}.");
        }

        public void RegistreraMedlem(Bibliotek bibliotek, Medlem medlem)
        {
            bibliotek.Medlemmar.Add(medlem);
            Console.WriteLine($"Medlem '{medlem.Namn}' registrerad av {Namn}.");
        }
    }
}

