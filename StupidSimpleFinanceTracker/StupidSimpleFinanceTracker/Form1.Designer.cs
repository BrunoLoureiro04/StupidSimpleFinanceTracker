namespace StupidSimpleFinanceTracker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rendimentoTextBox = new System.Windows.Forms.TextBox();
            this.addRendimentoBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.despesasPercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.poupancasPercent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.investimentosPercent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diversoesPercent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.diversoesSaldo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.investimentosSaldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.poupancasSaldo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.despesasSaldo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Total:";
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Location = new System.Drawing.Point(86, 39);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.ReadOnly = true;
            this.txtSaldoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adicionar Rendimento";
            // 
            // rendimentoTextBox
            // 
            this.rendimentoTextBox.Location = new System.Drawing.Point(347, 39);
            this.rendimentoTextBox.Name = "rendimentoTextBox";
            this.rendimentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.rendimentoTextBox.TabIndex = 3;
            // 
            // addRendimentoBtn
            // 
            this.addRendimentoBtn.Location = new System.Drawing.Point(453, 38);
            this.addRendimentoBtn.Name = "addRendimentoBtn";
            this.addRendimentoBtn.Size = new System.Drawing.Size(25, 21);
            this.addRendimentoBtn.TabIndex = 4;
            this.addRendimentoBtn.Text = "+";
            this.addRendimentoBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Budget";
            // 
            // despesasPercent
            // 
            this.despesasPercent.Location = new System.Drawing.Point(86, 102);
            this.despesasPercent.Name = "despesasPercent";
            this.despesasPercent.Size = new System.Drawing.Size(100, 20);
            this.despesasPercent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Despesas:";
            // 
            // poupancasPercent
            // 
            this.poupancasPercent.Location = new System.Drawing.Point(86, 128);
            this.poupancasPercent.Name = "poupancasPercent";
            this.poupancasPercent.Size = new System.Drawing.Size(100, 20);
            this.poupancasPercent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Poupanças:";
            // 
            // investimentosPercent
            // 
            this.investimentosPercent.Location = new System.Drawing.Point(277, 102);
            this.investimentosPercent.Name = "investimentosPercent";
            this.investimentosPercent.Size = new System.Drawing.Size(100, 20);
            this.investimentosPercent.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Investimentos:";
            // 
            // diversoesPercent
            // 
            this.diversoesPercent.Location = new System.Drawing.Point(277, 128);
            this.diversoesPercent.Name = "diversoesPercent";
            this.diversoesPercent.Size = new System.Drawing.Size(100, 20);
            this.diversoesPercent.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diversões:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(15, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rendimentos";
            // 
            // diversoesSaldo
            // 
            this.diversoesSaldo.Location = new System.Drawing.Point(277, 219);
            this.diversoesSaldo.Name = "diversoesSaldo";
            this.diversoesSaldo.ReadOnly = true;
            this.diversoesSaldo.Size = new System.Drawing.Size(100, 20);
            this.diversoesSaldo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Diversões:";
            // 
            // investimentosSaldo
            // 
            this.investimentosSaldo.Location = new System.Drawing.Point(277, 193);
            this.investimentosSaldo.Name = "investimentosSaldo";
            this.investimentosSaldo.ReadOnly = true;
            this.investimentosSaldo.Size = new System.Drawing.Size(100, 20);
            this.investimentosSaldo.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Investimentos:";
            // 
            // poupancasSaldo
            // 
            this.poupancasSaldo.Location = new System.Drawing.Point(86, 219);
            this.poupancasSaldo.Name = "poupancasSaldo";
            this.poupancasSaldo.ReadOnly = true;
            this.poupancasSaldo.Size = new System.Drawing.Size(100, 20);
            this.poupancasSaldo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Poupanças:";
            // 
            // despesasSaldo
            // 
            this.despesasSaldo.Location = new System.Drawing.Point(86, 193);
            this.despesasSaldo.Name = "despesasSaldo";
            this.despesasSaldo.ReadOnly = true;
            this.despesasSaldo.Size = new System.Drawing.Size(100, 20);
            this.despesasSaldo.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Despesas:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.Location = new System.Drawing.Point(15, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "Saldos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.Location = new System.Drawing.Point(15, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "Registo de Despesas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Categoria,
            this.Descricao,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(19, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.diversoesSaldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.investimentosSaldo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.poupancasSaldo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.despesasSaldo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.diversoesPercent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.investimentosPercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.poupancasPercent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.despesasPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addRendimentoBtn);
            this.Controls.Add(this.rendimentoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldoTotal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rendimentoTextBox;
        private System.Windows.Forms.Button addRendimentoBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox despesasPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox poupancasPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox investimentosPercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diversoesPercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox diversoesSaldo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox investimentosSaldo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox poupancasSaldo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox despesasSaldo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewComboBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}

