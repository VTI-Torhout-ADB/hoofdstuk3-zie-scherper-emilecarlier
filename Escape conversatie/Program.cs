namespace Escape_conversatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personage1 = "Alice";
            string personage2 = "Bob";
            string dialoog = $"{personage1} : Hoe gaat het met je?";
            Console.WriteLine(dialoog);
            string dialoog2 = $"  {personage2} : Goed, dank je. En met jou";
            Console.WriteLine(dialoog2);
            string dialoog3 = $"{personage1} : Ook goed, bedankt dat je het vraagt";
            Console.WriteLine(dialoog3);
        }
    }
}
