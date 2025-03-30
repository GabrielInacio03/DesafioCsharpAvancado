using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Honda : IVeiculo
    {
        public Honda() { }

        public string Marca { get; set ; }
        public string Nome { get; set ; }
        public int Ano { get; set; }

        public virtual void Salvar() //sobreescrita => polimorfismo
        {
            throw new NotImplementedException();
        }
        public void Excluir() //sobreescrita => polimorfismo
        {
            Console.WriteLine("Ação para excluir dados");
        }
    }
}
