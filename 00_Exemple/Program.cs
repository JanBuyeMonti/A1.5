using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        const string MARCA_FI = ".";
        string dada;
        int nMisssatge;
        nMisssatge = 0;
        dada = Console.ReadLine();
        while (dada!=MARCA_FI)
        {
            nMisssatge++;
            Console.WriteLine($"Iteracio {nMisssatge} --> {dada}");
            dada = Console.ReadLine();
        }

        Console.WriteLine($"TOTAL MISSATGES: {nMisssatge}");
    }
}