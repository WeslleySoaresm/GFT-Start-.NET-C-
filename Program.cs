// See https://aka.ms/new-console-template for more information
using System.Data;

using Dio.o_Estudos.ConceitoDeClass.Model;

Console.WriteLine("Hello, World!");
Console.WriteLine("exemplo");

// Criação de uma instância da classe Pessoa

Console.WriteLine("Digite o nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite a idade:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número do contribuinte:");
double contribuinte = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o email:");
string email = Console.ReadLine();

Console.WriteLine("Digite o telefone:");
string telefone = Console.ReadLine();

Pessoa pessoa = new Pessoa(nome, idade, contribuinte, email, telefone);
pessoa.Apresentar();