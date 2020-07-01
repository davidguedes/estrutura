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
        //Majoritariamente David e Giovanna
        //Declaração do atributo dado e do nó, do tipo Fila
        private Estrutura[] estruturaF;
        int ultimo = -1;

        //Construtor da Fila, tendo como requisito um valor int para definir seu tamanho
        public Fila(int numPosicao)
        {
            this.estruturaF = new Estrutura[numPosicao];
        }

        //Função inserir, responsável por inserir um valor na Fila
        public void Inserir(int elemento)
        {
            //Verifica a posição ultimo para saber se a Fila esta cheia, caso verdadeiro, o algoritmo é interrompido e é retornada uma mensagem
            if (this.ultimo >= this.estruturaF.Length-1)
            {
                MessageBox.Show("Não foi possível inserir.", "Fila Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Incremento do topo e instanciação da Estrutura
            this.ultimo++;
            Estrutura e1 = new Estrutura(elemento, null);

            //Verifica se a posição ultimo é maior que 0, caso verdadeiro, o valor anterior recebe em seu nodo o "caminho" do elemento atual
            if (this.ultimo > 0)
                this.estruturaF[ultimo - 1].proximo = e1;

            //Incremento de fato do elemento na posição ultimo
            this.estruturaF[this.ultimo] = e1;
            return;
        }

        public void Remover(){
            //Verifica a posicao ultimo, cao ele seja menor que 0 significa que a Fila esta vazia e portando não há elementos para serem removidos e então uma mensagem de alerta é retornada
            if(this.ultimo < 0){
                MessageBox.Show("Não foi possível remover.", "Fila Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Todos os elementos da Fila são “empurrados” para trás e o primeiro elemento que havia sido inserido é descartado, sendo setado nulo em seu lugar
            for (int i = 0; i < this.ultimo; i++){
                this.estruturaF[i] = this.estruturaF[i+1];
            }
            this.estruturaF[ultimo] = null;

            //Decremento do ultimo
            this.ultimo--;
            return;
        }

        //Função de exibição dos valores da Fila
        public void Mostrar(ListBox valores)
        {
            //Limpa a lista que receberá os valores da Fila
            valores.Items.Clear();

            //Percorre toda a fila e incrementa na posição correta dentro do Fila, até que todo o vetor tenha sido percorrido
            for (int i = 0; i < this.estruturaF.Length; i++)
            {
                if (this.estruturaF[i] != null)
                    valores.Items.Add(this.estruturaF[i].dado);
            }
        }
    }
}
