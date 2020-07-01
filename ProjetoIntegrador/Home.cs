using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public unsafe partial class formIndex : Form
    {
        //Feito simultanêamente pelos três integrantes para ideias de lugares dos itens e 
        //ideias para prevenção de possíveis erros
        Pilha pilha1;
        Fila fila1;
        Lista lista1;
        ListaLE listaLE1;

        public formIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        //Responsável por pegar o valor do campo e definir o tamanho das estruturas
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(txtTam.Text);
            pilha1 = new Pilha(num);
            fila1 = new Fila(num);
            txtTam.Enabled = false;
            btnEnviar.Enabled = false;
            btnInserir.Enabled = true;
            btnRemover.Enabled = true;
            txtValor.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Responsável por inserir o valor digitado na fila e pilha
        public void btnInserir_Click(object sender, EventArgs e)
        {
            //Verificação do campo Valor - caso esteja vazio, a ação é anulada retornando uma mensagem
            if (txtValor.Text != null)
            {
                pilha1.Inserir(Convert.ToInt32(txtValor.Text));
                pilha1.Mostrar(lbPilha);
                fila1.Inserir(Convert.ToInt32(txtValor.Text));
                fila1.Mostrar(lbFila);
                txtValor.Text = "";
            }
            else
                MessageBox.Show("Campo VALOR vazio, impossível de adicionar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Responsável por remover o valor das duas estruturas
        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            pilha1.Remover();
            pilha1.Mostrar(lbPilha);
            fila1.Remover();
            fila1.Mostrar(lbFila);
        }

        //Tratamento de possivel erro, prevenindo para que o usuário não consiga inserir espaços, letras ou cole algum conteúdo no código
        private void txtTam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        //Tratamento de possivel erro, prevenindo para que o usuário não consiga inserir espaços, letras ou cole algum conteúdo no código
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        //Ação prevenindo o espaço e ativando o botão Enviar quando o usuário der enter dentro do campo Tamanho
        private void txtTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar_Click(sender, e);
                txtValor.Focus();
            }

            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Ação prevenindo o espaço e ativando o botão Inserir quando o usuário der enter dentro do campo Valor
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
                btnInserir_Click(sender, e);
        }

        //Prevenindo o clique do botão direito dentro do campo Tamanho (evitando que o usuário cole caracteres ou tipos de dados diferente do permitido)
        private void txtTam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
        }

        //Prevenindo o clique do botão direito dentro do campo Valor (evitando que o usuário cole caracteres ou tipos de dados diferente do permitido)
        private void txtValor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
        }

        //Responsável por pegar o valor do campo e definir o tamanho das estruturas (Lista e Lista LE)
        private void btnEnviarLista_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(txtTamLista.Text);
            lista1 = new Lista(num);
            listaLE1 = new ListaLE(num);
            txtTamLista.Enabled = false;
            btnEnviarLista.Enabled = false;
            btnInserirLista.Enabled = true;
            btnRemoverLista.Enabled = true;
            txtValorLista.Enabled = true;
        }

        //Responsável por inserir o valor digitado na Lista e Lista LE
        private void btnInserirLista_Click(object sender, EventArgs e)
        {
            //Verificação do campo Valor - caso esteja vazio, a ação é anulada retornando uma mensagem
            if (txtValorLista.Text != null)
            {
                lista1.Inserir(Convert.ToInt32(txtValorLista.Text));
                lista1.Mostrar(lbLista);
                listaLE1.Inserir(Convert.ToInt32(txtValorLista.Text));
                listaLE1.Mostrar(lbListaLinearEncadeada);
                txtValorLista.Text = "";
            }
            else
                MessageBox.Show("Campo VALOR LISTA vazio, impossível de adicionar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Responsável por remover o valor das duas estruturas (Lista e Lista LE)
        private void btnRemoverLista_Click(object sender, EventArgs e)
        {
            lista1.Remover();
            lista1.Mostrar(lbLista);
            listaLE1.Remover();
            listaLE1.Mostrar(lbListaLinearEncadeada);
        }

        //Tratamento de possivel erro, prevenindo para que o usuário não consiga inserir espaços, letras ou cole algum conteúdo no código
        private void txtTamLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        //Tratamento de possivel erro, prevenindo para que o usuário não consiga inserir espaços, letras ou cole algum conteúdo no código
        private void txtValorLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        //Ação prevenindo o espaço e ativando o botão Enviar quando o usuário der enter dentro do campo Tamanho
        private void txtTamLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar_Click(sender, e);
                txtValor.Focus();
            }

            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Ação prevenindo o espaço e ativando o botão Inserir quando o usuário der enter dentro do campo Valor
        private void txtValorLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
                btnInserir_Click(sender, e);
        }

        //Prevenindo o clique do botão direito dentro do campo Tamanho (evitando que o usuário cole caracteres ou tipos de dados diferente do permitido)
        private void txtTamLista_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
        }

        //Prevenindo o clique do botão direito dentro do campo Valor (evitando que o usuário cole caracteres ou tipos de dados diferente do permitido)
        private void txtValorLista_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
