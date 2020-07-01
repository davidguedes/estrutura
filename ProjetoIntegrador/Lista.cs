using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    class Lista
    {
        //Feito por todos os usuários durante uma chamada
        //Declaração da estrutura e variavél que ajudara a controlar os limites da Lista
        private Estrutura[] estruturaL;
        int cont = -1;

        //Construtor da Lista exigindo um tamanho para sua criação
        public Lista(int numPosicao)
        {
            this.estruturaL = new Estrutura[numPosicao];
        }

        //Função de inserir na lista
        public void Inserir(int elemento)
        {
            //Verifica a posição atual onde será inserido para saber se a Lista esta cheia, caso verdadeiro, o algoritmo é interrompido e é retornada uma mensagem
            if (cont >= this.estruturaL.Length-1)
            {
                MessageBox.Show("Não foi possível inserir.", "Lista Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Incremento da variavel contadora
            this.cont++;

            //Instanciação da Estrutura
            Estrutura e1 = new Estrutura(elemento, null);

            //Incremento do elemento na Lista
            this.estruturaL[this.cont] = e1;
            
            return;
        }

        //Função responsável por remover da Lista
        public void Remover()
        {

            //Verifica a posição atual, caso o mesmo seja menor que 0 significa que a Lista está vazia e não há elementos para remover, retornando uma mensagem ao usuário
            if (this.cont < 0)
            {
                MessageBox.Show("Não foi possível remover.", "Lista Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Seta nulo para o valor removido
            this.estruturaL[this.cont] = null;

            //Decremento da posição contadora
            this.cont--;
            return;
        }

        //Função de exibição dos valores da Lista
        public void Mostrar(ListBox valores)
        {
            //Limpa a lista que receberá os valores
            valores.Items.Clear();

            //Percorre todo o vetor e incrementa na posição correta dentro da Lista, até que todo o vetor tenha sido percorrido
            for (int i = (this.estruturaL.Length - 1); i >= 0; i--)
            {
                if (this.estruturaL[i] != null)
                    valores.Items.Add(this.estruturaL[i].dado);
            }
        }
    }
}
