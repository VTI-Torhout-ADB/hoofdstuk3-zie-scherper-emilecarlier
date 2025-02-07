namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("geef een zelfstandig naamwoord: ");
            string zelfstandig_naamwoord = Console.ReadLine();
            Console.WriteLine("geef een adjectief: ");
            string adjectief = Console.ReadLine();
            Console.WriteLine("geef een werkwoord");
            string werkwoord = Console.ReadLine();
            Console.WriteLine("op een dag ging " + naam + " naar de AP Hogeschool. Hij zag daar een " + adjectief + " " + zelfstandig_naamwoord + " en vond het zo grappig dat hij begon te " + werkwoord);       
        }
    }
}
