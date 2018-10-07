namespace exercicio01_alunos
{
    partial class CadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodM = new System.Windows.Forms.TextBox();
            this.lblCodMatricula = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtFrequencia = new System.Windows.Forms.TextBox();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.tcCadAlunos = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnCadExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.btnListaExcluir = new System.Windows.Forms.Button();
            this.dtgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnListaAlterar = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.gpSituacao = new System.Windows.Forms.GroupBox();
            this.rtxSituacao = new System.Windows.Forms.RichTextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCadAlunos.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlunos)).BeginInit();
            this.gpSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(159, 107);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(162, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 24);
            this.txtNome.TabIndex = 4;
            // 
            // txtCodM
            // 
            this.txtCodM.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodM.Location = new System.Drawing.Point(29, 128);
            this.txtCodM.Name = "txtCodM";
            this.txtCodM.Size = new System.Drawing.Size(108, 24);
            this.txtCodM.TabIndex = 6;
            // 
            // lblCodMatricula
            // 
            this.lblCodMatricula.AutoSize = true;
            this.lblCodMatricula.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMatricula.Location = new System.Drawing.Point(26, 107);
            this.lblCodMatricula.Name = "lblCodMatricula";
            this.lblCodMatricula.Size = new System.Drawing.Size(105, 17);
            this.lblCodMatricula.TabIndex = 5;
            this.lblCodMatricula.Text = "Código Matrícula:";
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(29, 183);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(39, 24);
            this.txtNota1.TabIndex = 8;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(26, 162);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(49, 17);
            this.lblNota1.TabIndex = 7;
            this.lblNota1.Text = "Nota 1:";
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(95, 183);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(39, 24);
            this.txtNota2.TabIndex = 10;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(92, 162);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(51, 17);
            this.lblNota2.TabIndex = 9;
            this.lblNota2.Text = "Nota 2:";
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(162, 183);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(39, 24);
            this.txtNota3.TabIndex = 12;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(159, 162);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(51, 17);
            this.lblNota3.TabIndex = 11;
            this.lblNota3.Text = "Nota 3:";
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequencia.Location = new System.Drawing.Point(222, 183);
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.Size = new System.Drawing.Size(41, 24);
            this.txtFrequencia.TabIndex = 13;
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequencia.Location = new System.Drawing.Point(219, 162);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(71, 17);
            this.lblFrequencia.TabIndex = 14;
            this.lblFrequencia.Text = "Frequência:";
            // 
            // tcCadAlunos
            // 
            this.tcCadAlunos.Controls.Add(this.tpCadastro);
            this.tcCadAlunos.Controls.Add(this.tpLista);
            this.tcCadAlunos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCadAlunos.Location = new System.Drawing.Point(12, 12);
            this.tcCadAlunos.Name = "tcCadAlunos";
            this.tcCadAlunos.SelectedIndex = 0;
            this.tcCadAlunos.Size = new System.Drawing.Size(396, 354);
            this.tcCadAlunos.TabIndex = 15;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.gpSituacao);
            this.tpCadastro.Controls.Add(this.lblCod);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Controls.Add(this.txtCod);
            this.tpCadastro.Controls.Add(this.btnCadExcluir);
            this.tpCadastro.Controls.Add(this.txtNome);
            this.tpCadastro.Controls.Add(this.btnCadastrar);
            this.tpCadastro.Controls.Add(this.lblFrequencia);
            this.tpCadastro.Controls.Add(this.txtFrequencia);
            this.tpCadastro.Controls.Add(this.txtNota3);
            this.tpCadastro.Controls.Add(this.lblNota3);
            this.tpCadastro.Controls.Add(this.lblNome);
            this.tpCadastro.Controls.Add(this.txtNota2);
            this.tpCadastro.Controls.Add(this.lblCodMatricula);
            this.tpCadastro.Controls.Add(this.lblNota2);
            this.tpCadastro.Controls.Add(this.txtCodM);
            this.tpCadastro.Controls.Add(this.txtNota1);
            this.tpCadastro.Controls.Add(this.lblNota1);
            this.tpCadastro.Location = new System.Drawing.Point(4, 24);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(388, 326);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(85, 67);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(49, 24);
            this.txtCod.TabIndex = 23;
            this.txtCod.Leave += new System.EventHandler(this.txtCod_Leave);
            // 
            // btnCadExcluir
            // 
            this.btnCadExcluir.Location = new System.Drawing.Point(123, 292);
            this.btnCadExcluir.Name = "btnCadExcluir";
            this.btnCadExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnCadExcluir.TabIndex = 21;
            this.btnCadExcluir.Text = "Excluir";
            this.btnCadExcluir.UseVisualStyleBackColor = true;
            this.btnCadExcluir.Click += new System.EventHandler(this.btnCadExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 292);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.lblPesquisa);
            this.tpLista.Controls.Add(this.txtPesquisa);
            this.tpLista.Controls.Add(this.btnListaExcluir);
            this.tpLista.Controls.Add(this.dtgvAlunos);
            this.tpLista.Controls.Add(this.btnListaAlterar);
            this.tpLista.Location = new System.Drawing.Point(4, 24);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(388, 326);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista de Alunos";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // btnListaExcluir
            // 
            this.btnListaExcluir.Location = new System.Drawing.Point(109, 293);
            this.btnListaExcluir.Name = "btnListaExcluir";
            this.btnListaExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnListaExcluir.TabIndex = 18;
            this.btnListaExcluir.Text = "Excluir";
            this.btnListaExcluir.UseVisualStyleBackColor = true;
            this.btnListaExcluir.Click += new System.EventHandler(this.btnListaExcluir_Click);
            // 
            // dtgvAlunos
            // 
            this.dtgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nome,
            this.codM,
            this.nota1,
            this.nota2,
            this.nota3,
            this.frequencia,
            this.media,
            this.situacao});
            this.dtgvAlunos.Location = new System.Drawing.Point(12, 40);
            this.dtgvAlunos.Name = "dtgvAlunos";
            this.dtgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAlunos.Size = new System.Drawing.Size(364, 238);
            this.dtgvAlunos.TabIndex = 1;
            // 
            // btnListaAlterar
            // 
            this.btnListaAlterar.Location = new System.Drawing.Point(12, 293);
            this.btnListaAlterar.Name = "btnListaAlterar";
            this.btnListaAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnListaAlterar.TabIndex = 17;
            this.btnListaAlterar.Text = "Alterar";
            this.btnListaAlterar.UseVisualStyleBackColor = true;
            this.btnListaAlterar.Click += new System.EventHandler(this.btnListaAlterar_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(13, 13);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(171, 15);
            this.lblPesquisa.TabIndex = 20;
            this.lblPesquisa.Text = "Informe o Nome ou a Matrícula:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(190, 10);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(186, 23);
            this.txtPesquisa.TabIndex = 19;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cadastro de Alunos";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(26, 70);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(47, 17);
            this.lblCod.TabIndex = 25;
            this.lblCod.Text = "Código:";
            // 
            // gpSituacao
            // 
            this.gpSituacao.Controls.Add(this.rtxSituacao);
            this.gpSituacao.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSituacao.Location = new System.Drawing.Point(26, 223);
            this.gpSituacao.Name = "gpSituacao";
            this.gpSituacao.Size = new System.Drawing.Size(331, 55);
            this.gpSituacao.TabIndex = 26;
            this.gpSituacao.TabStop = false;
            this.gpSituacao.Text = "Situação";
            // 
            // rtxSituacao
            // 
            this.rtxSituacao.Location = new System.Drawing.Point(7, 18);
            this.rtxSituacao.Name = "rtxSituacao";
            this.rtxSituacao.ReadOnly = true;
            this.rtxSituacao.Size = new System.Drawing.Size(318, 28);
            this.rtxSituacao.TabIndex = 0;
            this.rtxSituacao.Text = "";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // codM
            // 
            this.codM.HeaderText = "Matrícula";
            this.codM.Name = "codM";
            this.codM.ReadOnly = true;
            this.codM.Width = 80;
            // 
            // nota1
            // 
            this.nota1.HeaderText = "Nota 1";
            this.nota1.Name = "nota1";
            this.nota1.ReadOnly = true;
            this.nota1.Width = 40;
            // 
            // nota2
            // 
            this.nota2.HeaderText = "Nota 2";
            this.nota2.Name = "nota2";
            this.nota2.ReadOnly = true;
            this.nota2.Width = 40;
            // 
            // nota3
            // 
            this.nota3.HeaderText = "Nota 3";
            this.nota3.Name = "nota3";
            this.nota3.ReadOnly = true;
            this.nota3.Width = 40;
            // 
            // frequencia
            // 
            this.frequencia.HeaderText = "Frequencia";
            this.frequencia.Name = "frequencia";
            this.frequencia.ReadOnly = true;
            this.frequencia.Width = 65;
            // 
            // media
            // 
            this.media.HeaderText = "Média";
            this.media.Name = "media";
            this.media.ReadOnly = true;
            this.media.Width = 45;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 150;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.tcCadAlunos);
            this.Name = "CadastroAluno";
            this.Text = "Cadastro de Alunos";
            this.tcCadAlunos.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.tpLista.ResumeLayout(false);
            this.tpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlunos)).EndInit();
            this.gpSituacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodM;
        private System.Windows.Forms.Label lblCodMatricula;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtFrequencia;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.TabControl tcCadAlunos;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.DataGridView dtgvAlunos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListaExcluir;
        private System.Windows.Forms.Button btnListaAlterar;
        private System.Windows.Forms.Button btnCadExcluir;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox gpSituacao;
        private System.Windows.Forms.RichTextBox rtxSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codM;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}

