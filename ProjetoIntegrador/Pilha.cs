using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    class Pilha
    {
        private Estrutura[] estruturaP;
        private int topo = -1;

        public Pilha(int numPosicao) {
            this.estruturaP = new Estrutura [numPosicao];
        }

        public bool InserirPilha(int elemento)
        {
            Estrutura e1 = new Estrutura(elemento, null);
            topo++;
            this.estruturaP[topo] = e1;
            return true;
        }

        public Estrutura[] getPilha() {
            return this.estruturaP;
        }
    }
}
