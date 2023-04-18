int y = 1;
int g = 0;

for (int x = 0; x < 11; x++)
{
    while (g < x)
    {
        for (; y < 11; y++)
        {
            int produto = x*y;
            Console.WriteLine($"{y} x {x} = {produto}");
        }
        y=1;
        g++;
    }
    Console.WriteLine($"");
}