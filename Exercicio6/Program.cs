// - Insira seu nome
// - salvar nome em um array
// - Pesquise um nome
// 	- if (pesquisa == nome)
// 		- achou
// 	- else 
// 		- nao achou

string[] nomes = new string[3];
bool estado = false;

for (var nome = 1; nome < 3; nome++)
{
    Console.WriteLine($"Insira um nome:");
    nomes[nome] = Console.ReadLine();   
}

do
{
    Console.WriteLine($"Pesquise um nome:");
    string pesquisa = Console.ReadLine();
    
    foreach (var item in nomes)
    {
        if (item == pesquisa)
        {
           Console.WriteLine($"achei");
            estado = true; 
            break;
        }
    }
    if (estado == false)
    {
        Console.WriteLine($"nao achei");
    }
   
    
} while (estado == false);