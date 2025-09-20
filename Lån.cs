using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    class Lån
    {
        public int LåneID { get; }
        public Bok Bok { get; }
        public Medlem Medlem { get; }
        public DateTime Lånedatum { get; }
        public DateTime Förfallo { get; private set; }

        private static int räknare = 1;

        public Lån(Medlem medlem, Bok bok)
        {
            LåneID = räknare++;
            Medlem = medlem;
            Bok = bok;
            Lånedatum = DateTime.Now;
            Förfallo = Lånedatum.AddDays(14);
        }

        public void Förläng()
        {
            Förfallo = Förfallo.AddDays(7);
            Console.WriteLine($"Lån {LåneID} förlängt. Nytt förfallo: {Förfallo:d}");
        }
    }
}
