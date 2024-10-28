const int valorFinal = 0;
int dada, nTotal;

nTotal = 0;

dada = Convert.ToInt32(Console.ReadLine());

while (dada != valorFinal)
{
    nTotal++;
    Console.WriteLine($"Iteració: {nTotal} --> {dada}");
    dada = Convert.ToInt32(Console.ReadLine());
  
}
Console.WriteLine($"TOTAL: {nTotal}");