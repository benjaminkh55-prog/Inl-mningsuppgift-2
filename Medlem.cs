using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    public class Medlem : Person
    {
        public int MedlemsID { get; }
        public string Tel { get; set; }

        public Medlem(int medlemsID, string namn, string epost, string tel)
            : base(namn, epost)
        {
            MedlemsID = medlemsID;
            Tel = tel;
        }

        public void LånaBok(Bok bok)
        {
            if (bok.Tillgänglig)
            {
                bok.Tillgänglig = false;
                Console.WriteLine($"{Namn} har lånat '{bok.Titel}'.");
            }
            else
            {
                Console.WriteLine($"Boken '{bok.Titel}' är utlånad.");
            }
        }

        public void LämnaTillbaka(Bok bok)
        {
            bok.Tillgänglig = true;
            Console.WriteLine($"{Namn} har lämnat tillbaka '{bok.Titel}'.");
        }
    }
}