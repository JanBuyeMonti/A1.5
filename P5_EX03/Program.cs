const int valorFinal = 0;
int dadaP, dadaN,dada;

dadaP = 0;
dadaN = 0;
dada = Convert.ToInt32(Console.ReadLine());

while (dada != valorFinal)
{
    if (dada > 0)
    {
        dadaP++;
        Console.WriteLine($"Negatius -->{dadaN} Positiu-->{dadaP}");
        dada = Convert.ToInt32(Console.ReadLine());

    }
    else
    {
        dadaN++;
        Console.WriteLine($"Negatius -->{dadaN} Positiu-->{dadaP}");
        dada = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine($"TOTAL: Negatius -->{dadaN} Positiu-->{dadaP}");