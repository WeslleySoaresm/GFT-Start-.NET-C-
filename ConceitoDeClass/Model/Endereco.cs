using System;

namespace Dio.o_Estudos.ConceitoDeClass.Model
{
    public class Endereco
    {
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        public Endereco(string rua, int numero, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
        }

        public void MostrarEndereco()
        {
            Console.WriteLine($"Endereço: {Rua}, {Numero} - {Cidade} /  {Estado}");
        }
    }
}