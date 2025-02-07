namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pcname = Environment.MachineName;
            string username = Environment.UserName;
            int proccount = Environment.ProcessorCount;
            long memory = Environment.WorkingSet;
            bool is64bit = Environment.Is64BitOperatingSystem;
            string specs = $"SysteemInformatie voor {username} op {pcname}";
            string processor = $"Aantal processors: {proccount}";
            string bit = $"64-bit besturingssysteem: {is64bit}";
            string geheugen = $"Huidige geheugengebruik: {memory}";
            Console.WriteLine(specs);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(processor);
            Console.WriteLine(bit);
            Console.WriteLine(geheugen);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
