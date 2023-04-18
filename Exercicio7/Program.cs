int[] numeros = new int[15];
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Insira o {i + 1}º numero:");
    numeros[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine("");
Array.Reverse(numeros);

foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}