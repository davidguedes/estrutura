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
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(178, 115);
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
            this.lbFila.Location = new System.Drawing.Point(85, 185);
            this.lbFila.Name = "lbFila";
            this.lbFila.Size = new System.Drawing.Size(120, 95);
            this.lbFila.TabIndex = 5;
            // 
            // lbPilha
            // 
            this.lbPilha.FormattingEnabled = true;
            this.lbPilha.Location = new System.Drawing.Point(244, 185);
            this.lbPilha.Name = "lbPilha";
            this.lbPilha.Size = new System.Drawing.Size(120, 95);
            this.lbPilha.TabIndex = 6;
            // 
            // txtTam
            // 
            this.txtTam.Location = new System.Drawing.Point(178, 29);
            this.txtTam.Name = "txtTam";
            this.txtTam.Size = new System.Drawing.Size(100, 20);
            this.txtTam.TabIndex = 7;
            this.txtTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTam_KeyDown);
            this.txtTam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTam_KeyPress);
            this.txtTam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTam_MouseDown);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(284, 26);
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
            this.btnRemover.Location = new System.Drawing.Point(97, 113);
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
            this.btnInserir.Location = new System.Drawing.Point(284, 113);
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
            this.lblFila.Location = new System.Drawing.Point(82, 169);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(23, 13);
            this.lblFila.TabIndex = 13;
            this.lblFila.Text = "Fila";
            // 
            // lblPilha
            // 
            this.lblPilha.AutoSize = true;
            this.lblPilha.Location = new System.Drawing.Point(241, 169);
            this.lblPilha.Name = "lblPilha";
            this.lblPilha.Size = new System.Drawing.Size(30, 13);
            this.lblPilha.TabIndex = 14;
            this.lblPilha.Text = "Pilha";
            // 
            // lblBaseF
            // 
            this.lblBaseF.AutoSize = true;
            this.lblBaseF.Location = new System.Drawing.Point(48, 267);
            this.lblBaseF.Name = "lblBaseF";
            this.lblBaseF.Size = new System.Drawing.Size(31, 13);
            this.lblBaseF.TabIndex = 11;
            this.lblBaseF.Text = "Base";
            this.lblBaseF.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTopoF
            // 
            this.lblTopoF.AutoSize = true;
            this.lblTopoF.Location = new System.Drawing.Point(47, 185);
            this.lblTopoF.Name = "lblTopoF";
            this.lblTopoF.Size = new System.Drawing.Size(32, 13);
            this.lblTopoF.TabIndex = 15;
            this.lblTopoF.Text = "Topo";
            // 
            // lblTopoP
            // 
            this.lblTopoP.AutoSize = true;
            this.lblTopoP.Location = new System.Drawing.Point(370, 185);
            this.lblTopoP.Name = "lblTopoP";
            this.lblTopoP.Size = new System.Drawing.Size(32, 13);
            this.lblTopoP.TabIndex = 17;
            this.lblTopoP.Text = "Topo";
            // 
            // lblBaseP
            // 
            this.lblBaseP.AutoSize = true;
            this.lblBaseP.Location = new System.Drawing.Point(371, 267);
            this.lblBaseP.Name = "lblBaseP";
            this.lblBaseP.Size = new System.Drawing.Size(31, 13);
            this.lblBaseP.TabIndex = 16;
            this.lblBaseP.Text = "Base";
            // 
            // formIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 320);
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
    }
}

