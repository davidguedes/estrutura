using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    class Pilha
    {
        private Estrutura[] estruturaP;
        private int topo = -1;

        public Pilha(int numPosicao) {
            this.estruturaP = new Estrutura [numPosicao];
        }

        public void Inserir(int elemento)
        {
            if (this.topo >= (estruturaP.Length-1)) {
                MessageBox.Show("Não foi possível inserir.", "Pilha Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.topo++;
            Estrutura e1 = new Estrutura(elemento, null);
            if (this.topo > 0) {
                this.estruturaP[topo - 1].proximo = e1;
            }

            this.estruturaP[this.topo] = e1;
            return;
        }

        public void Remover() {
            if (this.topo < 0) {
                MessageBox.Show("Não foi possível remover.", "Pilha Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.estruturaP[this.topo] = null;
            if (this.topo > 0) {
                this.estruturaP[this.topo - 1].proximo = null;
            }
            
            this.topo--;
            return;
        }

        public void Mostrar(ListBox valores)
        {
            valores.Items.Clear();


            for (int i = (this.estruturaP.Length - 1); i >= 0; i--)
            {
                if (this.estruturaP[i] != null)
                {
                    valores.Items.Add(this.estruturaP[i].dado);
                }
            }
        }

        public Estrutura[] getPilha() {
            return this.estruturaP;
        }
    }
}
