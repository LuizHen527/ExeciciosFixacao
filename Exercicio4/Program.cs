int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira o {i++}º numero:");
    numeros[i] = int.Parse(Console.ReadLine());
    
}

Console.WriteLine($"Maior numero {numeros.Max()} e menor numero {numeros.Min()}");
