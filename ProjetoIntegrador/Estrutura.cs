using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    unsafe class Estrutura
    {
        public int dado { set; get; }
        public Estrutura proximo { set; get; }

        public Estrutura(int dado, Estrutura prox = null)
        {
            this.dado = dado;
            this.proximo = prox;
        }
    }
}
