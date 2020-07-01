namespace ProjetoIntegrador
{
    partial class formIndex
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIndex));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbFila = new System.Windows.Forms.ListBox();
            this.lbPilha = new System.Windows.Forms.ListBox();
            this.txtTam = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblFila = new System.Windows.Forms.Label();
            this.lblPilha = new System.Windows.Forms.Label();
            this.lblBaseF = new System.Windows.Forms.Label();
            this.lblTopoF = new System.Windows.Forms.Label();
            this.lblTopoP = new System.Windows.Forms.Label();
            this.lblBaseP = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserirLista = new System.Windows.Forms.Button();
            this.btnRemoverLista = new System.Windows.Forms.Button();
            this.btnEnviarLista = new System.Windows.Forms.Button();
            this.txtTamLista = new System.Windows.Forms.TextBox();
            this.lbListaLinearEncadeada = new System.Windows.Forms.ListBox();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.txtValorLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(178, 175);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtValor_MouseDown);
            // 
            // lbFila
            // 
            this.lbFila.FormattingEnabled = true;
            this.lbFila.Location = new System.Drawing.Point(85, 245);
            this.lbFila.Name = "lbFila";
            this.lbFila.Size = new System.Drawing.Size(120, 95);
            this.lbFila.TabIndex = 5;
            // 
            // lbPilha
            // 
            this.lbPilha.FormattingEnabled = true;
            this.lbPilha.Location = new System.Drawing.Point(244, 245);
            this.lbPilha.Name = "lbPilha";
            this.lbPilha.Size = new System.Drawing.Size(120, 95);
            this.lbPilha.TabIndex = 6;
            // 
            // txtTam
            // 
            this.txtTam.Location = new System.Drawing.Point(178, 89);
            this.txtTam.Name = "txtTam";
            this.txtTam.Size = new System.Drawing.Size(100, 20);
            this.txtTam.TabIndex = 7;
            this.txtTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTam_KeyDown);
            this.txtTam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTam_KeyPress);
            this.txtTam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTam_MouseDown);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(284, 86);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(97, 173);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(284, 173);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(82, 229);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(23, 13);
            this.lblFila.TabIndex = 13;
            this.lblFila.Text = "Fila";
            // 
            // lblPilha
            // 
            this.lblPilha.AutoSize = true;
            this.lblPilha.Location = new System.Drawing.Point(241, 229);
            this.lblPilha.Name = "lblPilha";
            this.lblPilha.Size = new System.Drawing.Size(30, 13);
            this.lblPilha.TabIndex = 14;
            this.lblPilha.Text = "Pilha";
            // 
            // lblBaseF
            // 
            this.lblBaseF.AutoSize = true;
            this.lblBaseF.Location = new System.Drawing.Point(48, 327);
            this.lblBaseF.Name = "lblBaseF";
            this.lblBaseF.Size = new System.Drawing.Size(31, 13);
            this.lblBaseF.TabIndex = 11;
            this.lblBaseF.Text = "Base";
            this.lblBaseF.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTopoF
            // 
            this.lblTopoF.AutoSize = true;
            this.lblTopoF.Location = new System.Drawing.Point(47, 245);
            this.lblTopoF.Name = "lblTopoF";
            this.lblTopoF.Size = new System.Drawing.Size(32, 13);
            this.lblTopoF.TabIndex = 15;
            this.lblTopoF.Text = "Topo";
            // 
            // lblTopoP
            // 
            this.lblTopoP.AutoSize = true;
            this.lblTopoP.Location = new System.Drawing.Point(370, 245);
            this.lblTopoP.Name = "lblTopoP";
            this.lblTopoP.Size = new System.Drawing.Size(32, 13);
            this.lblTopoP.TabIndex = 17;
            this.lblTopoP.Text = "Topo";
            // 
            // lblBaseP
            // 
            this.lblBaseP.AutoSize = true;
            this.lblBaseP.Location = new System.Drawing.Point(371, 327);
            this.lblBaseP.Name = "lblBaseP";
            this.lblBaseP.Size = new System.Drawing.Size(31, 13);
            this.lblBaseP.TabIndex = 16;
            this.lblBaseP.Text = "Base";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(48, 96);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(124, 13);
            this.lblTamanho.TabIndex = 18;
            this.lblTamanho.Text = "Tamanho das estruturas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tamanho das estruturas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lista Linear Encadeada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Lista";
            // 
            // btnInserirLista
            // 
            this.btnInserirLista.Enabled = false;
            this.btnInserirLista.Location = new System.Drawing.Point(741, 175);
            this.btnInserirLista.Name = "btnInserirLista";
            this.btnInserirLista.Size = new System.Drawing.Size(75, 23);
            this.btnInserirLista.TabIndex = 25;
            this.btnInserirLista.Text = "Inserir";
            this.btnInserirLista.UseVisualStyleBackColor = true;
            this.btnInserirLista.Click += new System.EventHandler(this.btnInserirLista_Click);
            // 
            // btnRemoverLista
            // 
            this.btnRemoverLista.Enabled = false;
            this.btnRemoverLista.Location = new System.Drawing.Point(554, 175);
            this.btnRemoverLista.Name = "btnRemoverLista";
            this.btnRemoverLista.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverLista.TabIndex = 24;
            this.btnRemoverLista.Text = "Remover";
            this.btnRemoverLista.UseVisualStyleBackColor = true;
            this.btnRemoverLista.Click += new System.EventHandler(this.btnRemoverLista_Click);
            // 
            // btnEnviarLista
            // 
            this.btnEnviarLista.Location = new System.Drawing.Point(741, 88);
            this.btnEnviarLista.Name = "btnEnviarLista";
            this.btnEnviarLista.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarLista.TabIndex = 23;
            this.btnEnviarLista.Text = "Enviar";
            this.btnEnviarLista.UseVisualStyleBackColor = true;
            this.btnEnviarLista.Click += new System.EventHandler(this.btnEnviarLista_Click);
            // 
            // txtTamLista
            // 
            this.txtTamLista.Location = new System.Drawing.Point(635, 91);
            this.txtTamLista.Name = "txtTamLista";
            this.txtTamLista.Size = new System.Drawing.Size(100, 20);
            this.txtTamLista.TabIndex = 22;
            this.txtTamLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTamLista_KeyDown);
            this.txtTamLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamLista_KeyPress);
            this.txtTamLista.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTamLista_MouseDown);
            // 
            // lbListaLinearEncadeada
            // 
            this.lbListaLinearEncadeada.FormattingEnabled = true;
            this.lbListaLinearEncadeada.Location = new System.Drawing.Point(701, 247);
            this.lbListaLinearEncadeada.Name = "lbListaLinearEncadeada";
            this.lbListaLinearEncadeada.Size = new System.Drawing.Size(120, 95);
            this.lbListaLinearEncadeada.TabIndex = 21;
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(542, 247);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(120, 95);
            this.lbLista.TabIndex = 20;
            // 
            // txtValorLista
            // 
            this.txtValorLista.Enabled = false;
            this.txtValorLista.Location = new System.Drawing.Point(635, 177);
            this.txtValorLista.Name = "txtValorLista";
            this.txtValorLista.Size = new System.Drawing.Size(100, 20);
            this.txtValorLista.TabIndex = 19;
            this.txtValorLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorLista_KeyDown);
            this.txtValorLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorLista_KeyPress);
            this.txtValorLista.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtValorLista_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Pilha e Fila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Lista e Lista Linear Encadeada";
            // 
            // formIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInserirLista);
            this.Controls.Add(this.btnRemoverLista);
            this.Controls.Add(this.btnEnviarLista);
            this.Controls.Add(this.txtTamLista);
            this.Controls.Add(this.lbListaLinearEncadeada);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.txtValorLista);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.lblTopoP);
            this.Controls.Add(this.lblBaseP);
            this.Controls.Add(this.lblTopoF);
            this.Controls.Add(this.lblPilha);
            this.Controls.Add(this.lblFila);
            this.Controls.Add(this.lblBaseF);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtTam);
            this.Controls.Add(this.lbPilha);
            this.Controls.Add(this.lbFila);
            this.Controls.Add(this.txtValor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjetoIntegrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ListBox lbFila;
        private System.Windows.Forms.ListBox lbPilha;
        private System.Windows.Forms.TextBox txtTam;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.Label lblPilha;
        private System.Windows.Forms.Label lblBaseF;
        private System.Windows.Forms.Label lblTopoF;
        private System.Windows.Forms.Label lblTopoP;
        private System.Windows.Forms.Label lblBaseP;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserirLista;
        private System.Windows.Forms.Button btnRemoverLista;
        private System.Windows.Forms.Button btnEnviarLista;
        private System.Windows.Forms.TextBox txtTamLista;
        private System.Windows.Forms.ListBox lbListaLinearEncadeada;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.TextBox txtValorLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

