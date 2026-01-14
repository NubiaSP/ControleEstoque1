namespace ControleEstoque1.Formulario
{
    partial class Remover
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
            this.label2 = new System.Windows.Forms.Label();
            this.btNovoRemov = new System.Windows.Forms.Button();
            this.btCadastraRemov = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDRemov = new System.Windows.Forms.TextBox();
            this.cbTipoProdutoRemov = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListRemov = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRemov)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Remover Produto do Estoque";
            // 
            // btNovoRemov
            // 
            this.btNovoRemov.BackColor = System.Drawing.Color.Red;
            this.btNovoRemov.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNovoRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoRemov.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNovoRemov.Location = new System.Drawing.Point(203, 344);
            this.btNovoRemov.Name = "btNovoRemov";
            this.btNovoRemov.Size = new System.Drawing.Size(131, 39);
            this.btNovoRemov.TabIndex = 34;
            this.btNovoRemov.Text = "Novo";
            this.btNovoRemov.UseVisualStyleBackColor = false;
            // 
            // btCadastraRemov
            // 
            this.btCadastraRemov.BackColor = System.Drawing.Color.LightGreen;
            this.btCadastraRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastraRemov.Location = new System.Drawing.Point(31, 344);
            this.btCadastraRemov.Name = "btCadastraRemov";
            this.btCadastraRemov.Size = new System.Drawing.Size(131, 39);
            this.btCadastraRemov.TabIndex = 33;
            this.btCadastraRemov.Text = "Cadastrar";
            this.btCadastraRemov.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Selecione o tipo do produto";
            // 
            // txtIDRemov
            // 
            this.txtIDRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRemov.Location = new System.Drawing.Point(24, 178);
            this.txtIDRemov.Name = "txtIDRemov";
            this.txtIDRemov.Size = new System.Drawing.Size(232, 30);
            this.txtIDRemov.TabIndex = 29;
            // 
            // cbTipoProdutoRemov
            // 
            this.cbTipoProdutoRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoProdutoRemov.FormattingEnabled = true;
            this.cbTipoProdutoRemov.Items.AddRange(new object[] {
            " ProdutoFisico",
            " Ebook",
            " Curso"});
            this.cbTipoProdutoRemov.Location = new System.Drawing.Point(21, 100);
            this.cbTipoProdutoRemov.Name = "cbTipoProdutoRemov";
            this.cbTipoProdutoRemov.Size = new System.Drawing.Size(303, 33);
            this.cbTipoProdutoRemov.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Infome o ID do produto";
            // 
            // dgvListRemov
            // 
            this.dgvListRemov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRemov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.estoque});
            this.dgvListRemov.Location = new System.Drawing.Point(385, 72);
            this.dgvListRemov.Name = "dgvListRemov";
            this.dgvListRemov.RowHeadersWidth = 51;
            this.dgvListRemov.RowTemplate.Height = 24;
            this.dgvListRemov.Size = new System.Drawing.Size(381, 377);
            this.dgvListRemov.TabIndex = 35;
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
            // Remover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListRemov);
            this.Controls.Add(this.btNovoRemov);
            this.Controls.Add(this.btCadastraRemov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDRemov);
            this.Controls.Add(this.cbTipoProdutoRemov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Remover";
            this.Text = "Remover";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRemov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNovoRemov;
        private System.Windows.Forms.Button btCadastraRemov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDRemov;
        private System.Windows.Forms.ComboBox cbTipoProdutoRemov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListRemov;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    }
}