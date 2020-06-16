using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    class Pilha
    {
        private int? dado { get; set; }
        private Pilha proximo { get; set; }
        private int topo;

        public Pilha()
        {
            topo = -1;
        }

        Pilha[] pilha1;
        Form1 f = new Form1();

        bool IsEmpityPilha()
        {
            if (topo == -1)
                return true;
            else
                return false;
        }

        bool IsFullPilha()
        {
            if (topo == (pilha1.Length - 1))
                return true;
            else
                return false;
        }

        bool InserirPilha(int elemento)
        {
            if (IsFullPilha())
                return false;
            else
            {
                topo++;
                f.lblTopo.Text = Convert.ToString(topo);
                pilha1[topo].dado = elemento;
                return true;
            }
        }

        bool RemoverPilha()
        {
            if (IsEmpityPilha())
            {
                return false;
            }
            else
            {
                pilha1[topo].dado = null;
                topo--;
                f.lblTopo.Text = Convert.ToString(topo);
                return true;
            }
        }
    }
}
