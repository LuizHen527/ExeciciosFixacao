// - Insira o tipo de combustivel (A para alcool e G para gasolina)
// - Insira a quantidade de combustivel (litros)
// - Criar metodo Alcool (Retorna o total a pagar)
// 	- Valores: Quantidade
// 	- if(Quantidade <= 20)
// 		- desconto = Quantidade/0.03
// 		- preco = 4.90*Quantidade
// 		- return preco - desconto
// 	- else 
// 		- desconto = Quantidade/0.05
// 		- preco = 4.90*Quantidade
// 		- return preco - desconto

// -Criar metodo Gasolina
// 	- Valores: Quantidade
// 	- if(Quantidade <= 20)
// 		- desconto = Quantidade/0.04
// 		- preco = 5.30*Quantidade
// 		- return preco - desconto
// 	- else 
// 		- desconto = Quantidade/0.06
// 		- preco = 5.30*Quantidade
// 		- return preco - desconto

// - if(tipo == 'A')
// 	- O total a pagar e R$ {Alcool}
// - if(tipo == 'G')
// 	- O total a pagar e R$ {Gasolina}

//Code:

Console.WriteLine($"Insira o tipo de combustivel: ('A' para alcool ou 'G' para gasolina)");
char tipo = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"Insira a quantidade de combustivel: (litros)");
float quantidade = float.Parse(Console.ReadLine());


static double Alcool(float Quantidade)
{
    if(Quantidade <= 20)
    {
        double desconto = Quantidade*(4.9*0.03);
 		double preco = 4.90*Quantidade;
 		return preco - desconto;
    }
 		
 	else 
    {
        double desconto = Quantidade*(4.9*0.05);
 		double preco = 4.90*Quantidade;
 		return preco - desconto;
    }
 		
}
static double Gasolina(float Quantidade)
{
    if(Quantidade <= 20)
    {
        double desconto = Quantidade*(5.3*0.04);
 		double preco = 5.3*Quantidade;
 		return preco - desconto;
    }
 		
 	else 
    {
        double desconto = Quantidade*(4.9*0.06);
 		double preco = 5.3*Quantidade;
 		return preco - desconto;
    }
 		
}

switch(tipo)
{
    case 'A':
    Console.WriteLine($"Total a pagar no alcool: R$ {Math.Round(Alcool(quantidade), 2)}");
    break;

    case 'G':
    Console.WriteLine($"Total a pagar na gasolina: R$ {Math.Round(Gasolina(quantidade), 2)}");
    break;

    default:
    break;
}