using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    unsafe class Estrutura
    {
        //Majoritariamente David
        //Declaração do atributo dado e do nó, do tipo Estrutura
        public int dado { set; get; }
        public Estrutura proximo { set; get; }

        //Construtor responsável por "obrigar" a passagem de um valor dado quando um tipo Estrutura for instanciado
        public Estrutura(int dado, Estrutura prox = null)
        {
            this.dado = dado;
            this.proximo = prox;
        }
    }
}
