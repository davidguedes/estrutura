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
        Pilha pilha1;
        Fila fila1;

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

        public void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != null) {
                pilha1.Inserir(Convert.ToInt32(txtValor.Text));
                pilha1.Mostrar(lbPilha);
                fila1.Inserir(Convert.ToInt32(txtValor.Text));
                fila1.Mostrar(lbFila);
                txtValor.Text = "";
            }
            else
                MessageBox.Show("Campo VALOR vazio, impossível de adicionar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            pilha1.Remover();
            pilha1.Mostrar(lbPilha);
            fila1.Remover();
            fila1.Mostrar(lbFila);
        }

        private void txtTam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

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

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
                btnInserir_Click(sender, e);
        }

        private void txtTam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
        }

        private void txtValor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
        }
    }
}
