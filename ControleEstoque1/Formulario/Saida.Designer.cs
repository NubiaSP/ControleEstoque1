namespace ControleEstoque1.Formulario
{
    partial class Saida
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
            this.txtQntSaida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDSaida = new System.Windows.Forms.TextBox();
            this.cbTipoProdutoSaida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btNovoSaida = new System.Windows.Forms.Button();
            this.btCadastraSaida = new System.Windows.Forms.Button();
            this.dgvListSaida = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQntSaida
            // 
            this.txtQntSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntSaida.Location = new System.Drawing.Point(17, 274);
            this.txtQntSaida.Name = "txtQntSaida";
            this.txtQntSaida.Size = new System.Drawing.Size(230, 30);
            this.txtQntSaida.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Selecione o tipo do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Informe a Quantidade ";
            // 
            // txtIDSaida
            // 
            this.txtIDSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSaida.Location = new System.Drawing.Point(15, 193);
            this.txtIDSaida.Name = "txtIDSaida";
            this.txtIDSaida.Size = new System.Drawing.Size(232, 30);
            this.txtIDSaida.TabIndex = 13;
            // 
            // cbTipoProdutoSaida
            // 
            this.cbTipoProdutoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoProdutoSaida.FormattingEnabled = true;
            this.cbTipoProdutoSaida.Items.AddRange(new object[] {
            " ProdutoFisico",
            " Ebook",
            " Curso"});
            this.cbTipoProdutoSaida.Location = new System.Drawing.Point(12, 115);
            this.cbTipoProdutoSaida.Name = "cbTipoProdutoSaida";
            this.cbTipoProdutoSaida.Size = new System.Drawing.Size(303, 33);
            this.cbTipoProdutoSaida.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Infome o ID do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adicionando Saida  no Estoque ";
            // 
            // btNovoSaida
            // 
            this.btNovoSaida.BackColor = System.Drawing.Color.Red;
            this.btNovoSaida.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNovoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoSaida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNovoSaida.Location = new System.Drawing.Point(194, 359);
            this.btNovoSaida.Name = "btNovoSaida";
            this.btNovoSaida.Size = new System.Drawing.Size(131, 39);
            this.btNovoSaida.TabIndex = 21;
            this.btNovoSaida.Text = "Novo";
            this.btNovoSaida.UseVisualStyleBackColor = false;
            // 
            // btCadastraSaida
            // 
            this.btCadastraSaida.BackColor = System.Drawing.Color.LightGreen;
            this.btCadastraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastraSaida.Location = new System.Drawing.Point(22, 359);
            this.btCadastraSaida.Name = "btCadastraSaida";
            this.btCadastraSaida.Size = new System.Drawing.Size(131, 39);
            this.btCadastraSaida.TabIndex = 20;
            this.btCadastraSaida.Text = "Cadastrar";
            this.btCadastraSaida.UseVisualStyleBackColor = false;
            // 
            // dgvListSaida
            // 
            this.dgvListSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.estoque});
            this.dgvListSaida.Location = new System.Drawing.Point(331, 87);
            this.dgvListSaida.Name = "dgvListSaida";
            this.dgvListSaida.RowHeadersWidth = 51;
            this.dgvListSaida.RowTemplate.Height = 24;
            this.dgvListSaida.Size = new System.Drawing.Size(381, 377);
            this.dgvListSaida.TabIndex = 22;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 200;
            // 
            // estoque
            // 
            this.estoque.HeaderText = "Estoque";
            this.estoque.MinimumWidth = 6;
            this.estoque.Name = "estoque";
            this.estoque.Width = 80;
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 465);
            this.Controls.Add(this.dgvListSaida);
            this.Controls.Add(this.btNovoSaida);
            this.Controls.Add(this.btCadastraSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQntSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDSaida);
            this.Controls.Add(this.cbTipoProdutoSaida);
            this.Controls.Add(this.label1);
            this.Name = "Saida";
            this.Text = "Saida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQntSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDSaida;
        private System.Windows.Forms.ComboBox cbTipoProdutoSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNovoSaida;
        private System.Windows.Forms.Button btCadastraSaida;
        private System.Windows.Forms.DataGridView dgvListSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    }
}