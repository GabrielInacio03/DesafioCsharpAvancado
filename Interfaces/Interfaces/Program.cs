using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var veiculo = new HondaCivic();
            veiculo.Ano = 1999;
            veiculo.Marca = "Honda";
            veiculo.Nome = "Honda Civic Lx";
            veiculo.Salvar();
        }
    }
}
