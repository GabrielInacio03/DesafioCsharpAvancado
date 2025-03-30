using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class HondaCivic : Honda
    {
        public override void Salvar() //sobreescrita
        {
            Console.WriteLine("Salvando dados...");
        }
        public new void Excluir()
        {
            Console.WriteLine("excluindo dados do hondacivic");
        }
    }
}
