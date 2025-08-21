// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Runtime.CompilerServices;
using Dio.o_Estudos.ConceitoDeClass;
using Dio.o_Estudos.ConceitoDeClass.Model;

// Console.WriteLine("Hello, World!");
// Console.WriteLine("exemplo");

// // Criação de uma instância da classe Pessoa

// Console.WriteLine("Digite o nome:");
// string nome = Console.ReadLine();

// Console.WriteLine("Digite a idade:");
// int idade = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o número do contribuinte:");
// double contribuinte = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite o email:");
// string email = Console.ReadLine();

// Console.WriteLine("Digite o telefone:");
// string telefone = Console.ReadLine();

// Pessoa pessoa = new Pessoa(nome, idade, contribuinte, email, telefone);
// pessoa.Apresentar();

// // Criação de uma instância da classe Endereco
// Console.WriteLine("Digite a rua:");
// string rua = Console.ReadLine();

// Console.WriteLine("Digite o número:");
// int numero = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite a cidade:");
// string cidade = Console.ReadLine();

// Console.WriteLine("Digite o estado:");
// string estado = Console.ReadLine();

// Endereco endereco = new Endereco(rua, numero, cidade, estado);

// endereco.MostrarEndereco();

int a = Convert.ToInt32("5"); //convertendo um tipo para outro tipo
Console.WriteLine(a);

int b = int.Parse("5"); // vai converte de um strign para inteiro 32bytes
Console.WriteLine("convertendo com int.parse() " + a);

int inteiro = 5;
string c = inteiro.ToString(); //Convertendo inteiro para String

Console.WriteLine("Inteiro convertido para String usando ToString() " + a);


//Cast Implicito

int d = 5;
double e = d;

Console.WriteLine(e);

//Usando o TryParse 

string m = "15-"; //Aqui deixei com erro para o tryParse tenta converter 

int.TryParse(m, out int n);

Console.WriteLine(m);
Console.WriteLine("conversão feita com Sucesso!");

//Estrutura de Condição 


int quantidadeEmEstoque = 10;

            int quantidadeCompra = 4;

            bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

            Console.WriteLine($"Quantidade em estoue: {quantidadeEmEstoque}");
            Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
            Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");
            
            
            



            if (possivelVenda)
            {
                Console.WriteLine($"Venda realizada");
            }
            else
            {
                Console.WriteLine($"Desculpa. Não temos a quantidade desejada em estoque");
            }

            //Aprendendo o Switch case 

            Console.WriteLine($"Digite um letra");
            string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "b":
    case "c":
    case "d":
    case "i":
    case "f":
        Console.WriteLine($"Vogal");
        break;
    default:
        Console.WriteLine($"não é uma vogal");
        break;
                    
 }


// operador or ou ||
//se uma das condição for verdadeira ele vai executar o codigo.
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine($"Entrada Liberada!");

}
else
{
    Console.WriteLine($"Entrada nao liberada");

}

//Operador and (&&)
// ele precisa ver se tudo é verdadeiro para executar o codigo.

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine($"aprovado!");

}
else
{
    Console.WriteLine($"Reprovado!");

}


//INTACIANDO A CLASS CAUCULADORA

Calculadora cal = new Calculadora();


cal.Somar(10, 20);
cal.divisao(10, 5);
cal.Mutiplicar(10, 3);
cal.Subitrair(10, 5);
cal.Potencia(10, 3);
cal.Seno(30);
cal.Coseno(30);
cal.Tangente(30);
cal.RaizQuadrada(3);


//Incrmento e decremento 

int numero = 10;

Console.WriteLine($"{numero}");

Console.WriteLine($"Incremnto o 10");

numero++;  // numero = numero + 1;
// Para decremento é só colocar numero--;
Console.WriteLine(numero);


