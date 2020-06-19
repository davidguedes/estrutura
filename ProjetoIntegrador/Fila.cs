using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    class Fila
    {
        private Estrutura[] estruturaF;
        int ultimo = 0;
        
        public Fila(int numPosicao)
        {
            this.estruturaF = new Estrutura[numPosicao];
        }

        public void Inserir(int elemento)
        {
            if(this.ultimo > this.estruturaF.Length - 1)
            {
                MessageBox.Show("Não foi possível inserir.", "Fila Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Estrutura e1 = new Estrutura(elemento, null);

            if (this.ultimo > 0)
                this.estruturaF[ultimo - 1].proximo = e1;

            this.estruturaF[this.ultimo] = e1;
            this.ultimo++;
            return;
        }

        public void Remover(){
            if(this.ultimo < 0){
                MessageBox.Show("Não foi possível remover.", "Fila Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.estruturaF[0] = null;

            for(int i = 0; i < this.ultimo; i++){
                this.estruturaF[i] = this.estruturaF[i+1];
            }
            this.ultimo--;
            return;
        }

        public void Mostrar(ListBox valores)
        {
            valores.Items.Clear();

            for (int i = (this.estruturaF.Length - 1); i >= 0; i--)
            {
                if (this.estruturaF[i] != null)
                    valores.Items.Add(this.estruturaF[i].dado);
            }
        }
    }
}
