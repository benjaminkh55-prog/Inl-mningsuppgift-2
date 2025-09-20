namespace Inlämningsuppgift_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
    {
        static void Main()
        {
            var bibliotek = new Bibliotek("NBIsbiblioteket", "frölunda 1");
            var bibliotekarie = new Bibliotekarie(1, "Benji", "benji@bibliotek.se");
            var medlem = new Medlem(1001, "nemo", "nemo@mail.se", "0701234567");
            var bok = new Bok("Sagan om Ringen", "J.R.R. Tolkien", "123456");

            // Registrering av bok och medlem
            bibliotekarie.RegistreraBok(bibliotek, bok);
            bibliotekarie.RegistreraMedlem(bibliotek, medlem);

            // Lån och återlämning av bok
            medlem.LånaBok(bok);
            medlem.LämnaTillbaka(bok);

            // Skapa lån-objekt och förlänga lån
            var lån = new Lån(medlem, bok);
            lån.Förläng();

            Console.WriteLine("--- Programmet klart ---");
        }
    }
        }
    }
}
