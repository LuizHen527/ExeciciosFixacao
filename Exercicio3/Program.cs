// -Requisitos:
// 	- Nome
// 	- Quant.
// 	- Preco

// - Mostrar:
// 	- Preco sem desconto
// 	- O desconto
// 	- Preco com deconto


// Program:

// - Criar metodo Desconto
// 	- Mostrar o desconto no console

// - Insira o nome do produto:
//   (Produtos disponiveis: )

// - Insira a quantidade:

// - total = quantidade*preco

// - Mostrar total

// - Desconto(quantidade)

// - totalComDesconto = total - Desconto

// - Mostrar totalComDesconto

//Programa:

static double Produto(char produto)
{
    switch(produto)
    {
        case '1':
        return 15.00;

        case '2':
        return 100.00;

        default:
        return 0;
    }
}

static double Desconto(int quantidade, double precoTotal)
{
    if(quantidade <= 5)
    {
        return precoTotal*0.02;
    }

    else if(quantidade <= 10)
    {
        return precoTotal*0.03;
    }

    else
    {
        return precoTotal*0.05;
    }
}

Console.WriteLine($@"Insira o numero do produto:
produtos disponiveis: Papel Higienico - 1
                      Bacalhau - 2");

char produto = char.Parse(Console.ReadLine());

Console.WriteLine($"Insira a quantidade:");

int quantidade = int.Parse(Console.ReadLine());

double total = quantidade*Produto(produto);

Console.WriteLine($"Preco total: R$ {total}");

Console.WriteLine($"Desconto por comprar {quantidade} unidades: R$ {Desconto(quantidade, total)}");

double totalComDesconto = total - Desconto(quantidade, total);

Console.WriteLine($"O total a pagar com desconto: R$ {totalComDesconto}");
