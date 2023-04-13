// - Insira seu ano de nacimento:
// - processar
// 	- idade = anoAtual - anoNascimento;
// 	- if(idade => 18)
// 		- Pode votar
// 	- else
// 		- Nao pode votar

Console.WriteLine($"Insira seu ano de nascimento:");
int anoNascimento = int.Parse(Console.ReadLine());

DateTime dataAtual = DateTime.Now;
int anoAtual = dataAtual.Year;
int idade = anoAtual - anoNascimento;

Console.WriteLine(idade);
Console.WriteLine(anoAtual);



if(idade < 18)
{
    Console.WriteLine($"Nao pode votar");
}

else
{
    Console.WriteLine($"Pode votar");
}