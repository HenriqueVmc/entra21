namespace introducaoWinForms
{
    partial class CadastroProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.txtVal3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.txtVal4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVal4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numQtd1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numQtd2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numQtd4 = new System.Windows.Forms.NumericUpDown();
            this.numQtd3 = new System.Windows.Forms.NumericUpDown();
            this.lblQtd4 = new System.Windows.Forms.Label();
            this.lblQtd3 = new System.Windows.Forms.Label();
            this.lblQtd2 = new System.Windows.Forms.Label();
            this.lblQtd1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(55, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "R$";
            // 
            // txtVal1
            // 
            this.txtVal1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal1.Location = new System.Drawing.Point(199, 43);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(48, 23);
            this.txtVal1.TabIndex = 8;
            this.txtVal1.Text = "0";
            this.txtVal1.Click += new System.EventHandler(this.txtVal1_Click);
            this.txtVal1.Leave += new System.EventHandler(this.txtVal1_Leave);
            // 
            // txtVal2
            // 
            this.txtVal2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal2.Location = new System.Drawing.Point(199, 77);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(48, 23);
            this.txtVal2.TabIndex = 13;
            this.txtVal2.Text = "0";
            this.txtVal2.Click += new System.EventHandler(this.txtVal2_Click);
            this.txtVal2.Leave += new System.EventHandler(this.txtVal2_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "R$";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal2.Location = new System.Drawing.Point(135, 79);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(43, 16);
            this.lblVal2.TabIndex = 11;
            this.lblVal2.Text = "Valor:";
            // 
            // txtVal3
            // 
            this.txtVal3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal3.Location = new System.Drawing.Point(199, 112);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.Size = new System.Drawing.Size(48, 23);
            this.txtVal3.TabIndex = 18;
            this.txtVal3.Text = "0";
            this.txtVal3.Click += new System.EventHandler(this.txtVal3_Click);
            this.txtVal3.Leave += new System.EventHandler(this.txtVal3_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "R$";
            // 
            // lblVal3
            // 
            this.lblVal3.AutoSize = true;
            this.lblVal3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal3.Location = new System.Drawing.Point(135, 114);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(43, 16);
            this.lblVal3.TabIndex = 16;
            this.lblVal3.Text = "Valor:";
            // 
            // txtVal4
            // 
            this.txtVal4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal4.Location = new System.Drawing.Point(199, 148);
            this.txtVal4.Name = "txtVal4";
            this.txtVal4.Size = new System.Drawing.Size(48, 23);
            this.txtVal4.TabIndex = 23;
            this.txtVal4.Text = "0";
            this.txtVal4.Click += new System.EventHandler(this.txtVal4_Click);
            this.txtVal4.Leave += new System.EventHandler(this.txtVal4_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "R$";
            // 
            // lblVal4
            // 
            this.lblVal4.AutoSize = true;
            this.lblVal4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal4.Location = new System.Drawing.Point(135, 151);
            this.lblVal4.Name = "lblVal4";
            this.lblVal4.Size = new System.Drawing.Size(43, 16);
            this.lblVal4.TabIndex = 21;
            this.lblVal4.Text = "Valor:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(15, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 30);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(302, 202);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 19);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(381, 199);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(62, 27);
            this.txtTotal.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "R$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbResultado);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(264, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 165);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado:";
            // 
            // rtbResultado
            // 
            this.rtbResultado.Enabled = false;
            this.rtbResultado.Location = new System.Drawing.Point(9, 20);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(156, 131);
            this.rtbResultado.TabIndex = 30;
            this.rtbResultado.Text = "";
            this.rtbResultado.EnabledChanged += new System.EventHandler(this.rtbResultado_EnabledChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(139, 198);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 30);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(84, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "*";
            // 
            // numQtd1
            // 
            this.numQtd1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd1.Location = new System.Drawing.Point(96, 44);
            this.numQtd1.Name = "numQtd1";
            this.numQtd1.Size = new System.Drawing.Size(33, 23);
            this.numQtd1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(84, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "*";
            // 
            // numQtd2
            // 
            this.numQtd2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd2.Location = new System.Drawing.Point(96, 77);
            this.numQtd2.Name = "numQtd2";
            this.numQtd2.Size = new System.Drawing.Size(33, 23);
            this.numQtd2.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(85, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(85, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "*";
            // 
            // numQtd4
            // 
            this.numQtd4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd4.Location = new System.Drawing.Point(96, 146);
            this.numQtd4.Name = "numQtd4";
            this.numQtd4.Size = new System.Drawing.Size(33, 23);
            this.numQtd4.TabIndex = 38;
            // 
            // numQtd3
            // 
            this.numQtd3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd3.Location = new System.Drawing.Point(96, 110);
            this.numQtd3.Name = "numQtd3";
            this.numQtd3.Size = new System.Drawing.Size(33, 23);
            this.numQtd3.TabIndex = 37;
            // 
            // lblQtd4
            // 
            this.lblQtd4.AutoSize = true;
            this.lblQtd4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd4.Location = new System.Drawing.Point(12, 150);
            this.lblQtd4.Name = "lblQtd4";
            this.lblQtd4.Size = new System.Drawing.Size(76, 16);
            this.lblQtd4.TabIndex = 42;
            this.lblQtd4.Text = "Quantidade:";
            // 
            // lblQtd3
            // 
            this.lblQtd3.AutoSize = true;
            this.lblQtd3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd3.Location = new System.Drawing.Point(12, 114);
            this.lblQtd3.Name = "lblQtd3";
            this.lblQtd3.Size = new System.Drawing.Size(76, 16);
            this.lblQtd3.TabIndex = 41;
            this.lblQtd3.Text = "Quantidade:";
            // 
            // lblQtd2
            // 
            this.lblQtd2.AutoSize = true;
            this.lblQtd2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd2.Location = new System.Drawing.Point(12, 79);
            this.lblQtd2.Name = "lblQtd2";
            this.lblQtd2.Size = new System.Drawing.Size(76, 16);
            this.lblQtd2.TabIndex = 40;
            this.lblQtd2.Text = "Quantidade:";
            // 
            // lblQtd1
            // 
            this.lblQtd1.AutoSize = true;
            this.lblQtd1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd1.Location = new System.Drawing.Point(12, 45);
            this.lblQtd1.Name = "lblQtd1";
            this.lblQtd1.Size = new System.Drawing.Size(76, 16);
            this.lblQtd1.TabIndex = 39;
            this.lblQtd1.Text = "Quantidade:";
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 233);
            this.Controls.Add(this.lblQtd4);
            this.Controls.Add(this.lblQtd3);
            this.Controls.Add(this.lblQtd2);
            this.Controls.Add(this.lblQtd1);
            this.Controls.Add(this.numQtd4);
            this.Controls.Add(this.numQtd3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numQtd2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numQtd1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVal4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVal4);
            this.Controls.Add(this.txtVal3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVal3);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProdutos";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQtd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.TextBox txtVal3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVal3;
        private System.Windows.Forms.TextBox txtVal4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVal4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numQtd1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numQtd2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numQtd4;
        private System.Windows.Forms.NumericUpDown numQtd3;
        private System.Windows.Forms.Label lblQtd4;
        private System.Windows.Forms.Label lblQtd3;
        private System.Windows.Forms.Label lblQtd2;
        private System.Windows.Forms.Label lblQtd1;
    }
}