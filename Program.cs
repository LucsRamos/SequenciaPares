Console.WriteLine("Números pares entre 0 e ? ");
int NumeroInformado = Convert.ToInt32(Console.ReadLine());
if (NumeroInformado >= 1)
{
    int NumeroPar = 0;
    while (NumeroPar <= NumeroInformado)
    {
        Console.Write($"{NumeroPar} ");
        NumeroPar += 2;
    }
}
else
{
    Console.WriteLine($"O número {NumeroInformado} não é inteiro positivo. ");
}