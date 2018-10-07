namespace ExemploBD_02
{
    partial class ListaHerois
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
            this.dtgvHerois = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaBancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.rdbFiltrosCB = new System.Windows.Forms.RadioButton();
            this.rdbFiltrosRaca = new System.Windows.Forms.RadioButton();
            this.rdbFiltrosNome = new System.Windows.Forms.RadioButton();
            this.cbOrdenacao = new System.Windows.Forms.ComboBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerois)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHerois
            // 
            this.dtgvHerois.AllowUserToAddRows = false;
            this.dtgvHerois.AllowUserToDeleteRows = false;
            this.dtgvHerois.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHerois.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nome,
            this.raca,
            this.contaBancaria});
            this.dtgvHerois.Location = new System.Drawing.Point(103, 34);
            this.dtgvHerois.Name = "dtgvHerois";
            this.dtgvHerois.ReadOnly = true;
            this.dtgvHerois.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHerois.Size = new System.Drawing.Size(420, 199);
            this.dtgvHerois.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 130;
            // 
            // raca
            // 
            this.raca.HeaderText = "Raça";
            this.raca.Name = "raca";
            this.raca.ReadOnly = true;
            // 
            // contaBancaria
            // 
            this.contaBancaria.HeaderText = "Conta Bancária";
            this.contaBancaria.Name = "contaBancaria";
            this.contaBancaria.ReadOnly = true;
            this.contaBancaria.Width = 130;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(282, 245);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Location = new System.Drawing.Point(449, 245);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(75, 23);
            this.btnEstatisticas.TabIndex = 5;
            this.btnEstatisticas.Text = "Estatisticas";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(14, 176);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(159, 9);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(224, 20);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(100, 12);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 7;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(192, 245);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(101, 245);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.rdbFiltrosCB);
            this.gbFiltros.Controls.Add(this.rdbFiltrosRaca);
            this.gbFiltros.Controls.Add(this.rdbFiltrosNome);
            this.gbFiltros.Location = new System.Drawing.Point(14, 72);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(75, 95);
            this.gbFiltros.TabIndex = 9;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // rdbFiltrosCB
            // 
            this.rdbFiltrosCB.AutoSize = true;
            this.rdbFiltrosCB.Location = new System.Drawing.Point(11, 69);
            this.rdbFiltrosCB.Name = "rdbFiltrosCB";
            this.rdbFiltrosCB.Size = new System.Drawing.Size(39, 17);
            this.rdbFiltrosCB.TabIndex = 2;
            this.rdbFiltrosCB.TabStop = true;
            this.rdbFiltrosCB.Text = "CB";
            this.rdbFiltrosCB.UseVisualStyleBackColor = true;
            // 
            // rdbFiltrosRaca
            // 
            this.rdbFiltrosRaca.AutoSize = true;
            this.rdbFiltrosRaca.Location = new System.Drawing.Point(11, 46);
            this.rdbFiltrosRaca.Name = "rdbFiltrosRaca";
            this.rdbFiltrosRaca.Size = new System.Drawing.Size(51, 17);
            this.rdbFiltrosRaca.TabIndex = 1;
            this.rdbFiltrosRaca.TabStop = true;
            this.rdbFiltrosRaca.Text = "Raça";
            this.rdbFiltrosRaca.UseVisualStyleBackColor = true;
            // 
            // rdbFiltrosNome
            // 
            this.rdbFiltrosNome.AutoSize = true;
            this.rdbFiltrosNome.Location = new System.Drawing.Point(11, 23);
            this.rdbFiltrosNome.Name = "rdbFiltrosNome";
            this.rdbFiltrosNome.Size = new System.Drawing.Size(53, 17);
            this.rdbFiltrosNome.TabIndex = 0;
            this.rdbFiltrosNome.TabStop = true;
            this.rdbFiltrosNome.Text = "Nome";
            this.rdbFiltrosNome.UseVisualStyleBackColor = true;
            this.rdbFiltrosNome.CheckedChanged += new System.EventHandler(this.rdbFiltrosNome_CheckedChanged);
            // 
            // cbOrdenacao
            // 
            this.cbOrdenacao.FormattingEnabled = true;
            this.cbOrdenacao.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.cbOrdenacao.Location = new System.Drawing.Point(462, 9);
            this.cbOrdenacao.Name = "cbOrdenacao";
            this.cbOrdenacao.Size = new System.Drawing.Size(61, 21);
            this.cbOrdenacao.TabIndex = 10;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(408, 12);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(48, 13);
            this.lblOrdenar.TabIndex = 11;
            this.lblOrdenar.Text = "Ordenar:";
            // 
            // ListaHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 279);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.cbOrdenacao);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnEstatisticas);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtgvHerois);
            this.Name = "ListaHerois";
            this.Text = "Lista de Herois";
            this.Activated += new System.EventHandler(this.ListaHerois_Activated);
            this.Load += new System.EventHandler(this.ListaHerois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerois)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHerois;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEstatisticas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.RadioButton rdbFiltrosCB;
        private System.Windows.Forms.RadioButton rdbFiltrosRaca;
        private System.Windows.Forms.RadioButton rdbFiltrosNome;
        private System.Windows.Forms.ComboBox cbOrdenacao;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaBancaria;
    }
}