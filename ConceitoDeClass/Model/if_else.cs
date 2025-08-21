using System;
using System.Data;
using System.Runtime.CompilerServices;
using Dio.o_Estudos.ConceitoDeClass.Model;

namespace Dio.o_Estudos.ConceitoDeClass.Model
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
