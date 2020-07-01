using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    class ListaLE
    {
        //Majoritariamente David
        //Declaração da estrutura e variavél que ajudara a controlar os limites da Lista LE
        private Estrutura[] estruturaLLE;
        int cont = -1;

        //Construtor da Lista LE exigindo um tamanho para sua criação
        public ListaLE(int numPosicao)
        {
            this.estruturaLLE = new Estrutura[numPosicao];
        }

        //Função de inserir na lista LE
        public void Inserir(int elemento)
        {
            //Verifica a posição atual onde será inserido para saber se a Lista LE esta cheia, caso verdadeiro, o algoritmo é interrompido e é retornada uma mensagem
            if (cont >= this.estruturaLLE.Length - 1)
            {
                MessageBox.Show("Não foi possível inserir.", "Lista LE Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Incremento da variavel contadora
            this.cont++;

            //Instanciação da Estrutura
            Estrutura e1 = new Estrutura(elemento, null);

            //Verifica se a posicao atual é maior que 0, caso verdadeiro, o valor anterior recebe em seu nodo o "caminho" do elemento atual para fazer o encadeamento
            if (this.cont > 0)
                this.estruturaLLE[cont - 1].proximo = e1;


            //Incremento do elemento na Lista LE
            this.estruturaLLE[this.cont] = e1;

            return;
        }

        //Função responsável por remover da Lista LE
        public void Remover()
        {

            //Verifica a posição atual, caso o mesmo seja menor que 0 significa que a Lista LE está vazia e não há elementos para remover, retornando uma mensagem ao usuário
            if (this.cont < 0)
            {
                MessageBox.Show("Não foi possível remover.", "Lista LE Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Seta nulo para o valor removido
            this.estruturaLLE[this.cont] = null;

            //Verifica se a posição atual é maior que 0, caso verdadeiro, o nodo do valor anterior recebe nulo, já que este contém o caminho do elemento a ser destruido
            if (this.cont > 0)
                this.estruturaLLE[this.cont - 1].proximo = null;

            //Decremento da posição contadora
            this.cont--;
            return;
        }

        //Função de exibição dos valores da Lista LE
        public void Mostrar(ListBox valores)
        {
            //Limpa a lista que receberá os valores
            valores.Items.Clear();

            //Percorre todo o vetor e incrementa na posição correta dentro da Lista LE, até que todo o vetor tenha sido percorrido
            for (int i = (this.estruturaLLE.Length - 1); i >= 0; i--)
            {
                if (this.estruturaLLE[i] != null)
                    valores.Items.Add(this.estruturaLLE[i].dado);
            }
        }
    }
}
