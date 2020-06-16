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
    public unsafe partial class Form1 : Form
    {
        Pilha[] p1;

        int primeiro = 0, ultimo = 0, total = 0;
       
        Fila[] fila1;
        
        struct Fila {
            public int? dado { get; set; }
        }

        bool InserirFila(int elemento)
        {
            if (IsFullFila())
                return false;
            else
            {
                fila1[ultimo].dado = elemento;
                ultimo = (ultimo + 1) % fila1.Length;
                total++;
                return true;
            }
        }

        bool RemoverFila()
        {
            if (IsEmpityFila())
                //atenção
                return false;
            else
            {
                //atenção
                return true;
            }
        }

        bool IsEmpityFila()
        {
            if (total == 0)
                return true;
            else
                return false;
        }

        bool IsFullFila()
        {
            if (total == fila1.Length)
                return true;
            else
                return false;
        }

        Pilha[] pilha1;
        int topo = -1;

        struct Pilha
        {
            public int? dado { get; set; }
        }

        bool InserirPilha(int elemento)
        {
            if (IsFullPilha())
                return false;
            else
            {
                topo++;
                lblTopo.Text = Convert.ToString(topo);
                pilha1[topo].dado = elemento;
                return true;
            }
        }

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
                lblTopo.Text = Convert.ToString(topo);
                return true;
            }
        }

        public Form1()
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
            pilha1 = new Pilha[num];
            fila1 = new Fila[num];
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
                if((InserirPilha(Convert.ToInt32(txtValor.Text)) == true) && (InserirFila(Convert.ToInt32(txtValor.Text)) == true))
                {
                    lbPilha.Items.Add(pilha1[topo].dado);
                    lbFila.Items.Add(fila1[ultimo].dado);
                    txtValor.Text = "";
                }
                else
                    MessageBox.Show("Fila/Pilha cheia, impossível de adicionar!", "Is Full", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Campo VALOR vazio, impossível de adicionar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (RemoverPilha() && RemoverFila())
                lbPilha.Items.RemoveAt(topo+1);
            else
                MessageBox.Show("Fila/Pilha vazia, impossível de remover!", "Is Empity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
