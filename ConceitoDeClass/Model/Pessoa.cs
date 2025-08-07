using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.o_Estudos.ConceitoDeClass.Model
{
    public class Pessoa // Classe Pessoa
    {
        // Atributos da classe Pessoa
        // Atributos são as características da classe
        public string? Nome { get; set; } 
        public int Idade { get; set; }
        public double Contribuinte  { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }


        // Construtor padrão
        public Pessoa(string nome, int idade, double Contribuinte, string email, string telefone) // Construtor com parâmetros
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Contribuinte = Contribuinte;
            this.Email = email;
            this.Telefone = telefone;
        }
        

        
        // Método para apresentar os dados da pessoa
        // Métodos são as ações que a classe pode realizar
        
        public void Apresentar()
        {
            DateTime dataAtual = DateTime.Now; // Obtém a data e hora atual
            Console.WriteLine($"Data atual: {dataAtual.ToShortDateString()}"); // Exibe a data atual
            Console.WriteLine($"Hora atual: {dataAtual.ToShortTimeString()}"); // Exibe a hora atual
            Console.WriteLine($"Contribuinte: {Contribuinte}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");

        }
    }


    }




    // Diagrama UML da Classe Pessoa

/*+-------------------+
|      Pessoa       |
+-------------------+
| - Nome: string    |
| - Idade: int      |
+-------------------+
| + Apresentar()    |*/
// See https://aka.ms/new-console-template for more information