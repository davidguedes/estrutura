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
        //Majoritariamente Enzo
        //Declaração do atributo dado e do nó, do tipo Estrutura
        private Estrutura[] estruturaP;
        private int topo = -1;

        //Construtor da Pilha, tendo como requisito um valor int para definir seu tamanho
        public Pilha(int numPosicao) {
            this.estruturaP = new Estrutura[numPosicao];
        }

        //Função inserir, responsável por inserir um valor na Pilha
        public void Inserir(int elemento)
        {
            //Verifica a posição topo para saber se a Pilha esta cheia, caso verdadeiro, o algoritmo é interrompido e é retornada uma mensagem
            if (this.topo >= (this.estruturaP.Length-1)) {
                MessageBox.Show("Não foi possível inserir.", "Pilha Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Incremento do topo e instanciação da Estrutura
            this.topo++;
            Estrutura e1 = new Estrutura(elemento, null);

            //Verifica se a posicao topo é maior que 0, caso verdadeiro, o valor anterior recebe em seu nodo o "caminho" do elemento atual
            if (this.topo > 0)
                this.estruturaP[topo - 1].proximo = e1;

            //Incremento de fato do elemento na posição topo
            this.estruturaP[this.topo] = e1;
            return;
        }

        //Função responsável por remover da Pilha
        public void Remover() {

            //Verifica a posição do topo, caso o mesmo seja menor que 0 significa que a Pilha está vazia e não há elementos para remover, retornando uma mensagem ao usuário
            if (this.topo < 0) {
                MessageBox.Show("Não foi possível remover.", "Pilha Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Seta nulo para o valor removido
            this.estruturaP[this.topo] = null;

            //Verifica se o topo é maior que 0, caso verdadeiro, o nodo do valor anterior recebe nulo
            if (this.topo > 0)
                this.estruturaP[this.topo - 1].proximo = null;
            
            //Decremento da posição topo
            this.topo--;
            return;
        }

        //Função de exibição dos valores da Pilha
        public void Mostrar(ListBox valores)
        {
            //Limpa a lista que receberá os valores da Pilha
            valores.Items.Clear();

            //Função reverse para que a lista seja exibida de forma inversa, para uma melhor didática e visualização do usuário – já que temos em mente o conceito de pilha como algo em cima do outro, como uma pilha de livros por exemplo
            this.estruturaP.Reverse();

            //Percorre toda a pilha e incrementa na posição correta dentro da Pilha, até que todo o vetor tenha sido percorrido
            for (int i = (this.estruturaP.Length - 1); i >= 0; i--)
            {
                if (this.estruturaP[i] != null)
                    valores.Items.Add(this.estruturaP[i].dado);
            }
        }

        public Estrutura[] getPilha() {
            return this.estruturaP;
        }
    }
}
