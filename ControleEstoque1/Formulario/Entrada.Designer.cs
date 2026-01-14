namespace ControleEstoque1.Formulario
{
    partial class Entrada
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
            this.btNovoEntra = new System.Windows.Forms.Button();
            this.btCadastraEntra = new System.Windows.Forms.Button();
            this.txtQntEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDEntrada = new System.Windows.Forms.TextBox();
            this.cbTipoProdutoEntra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListEntrada = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Entrada de Estoque Produto ";
            // 
            // btNovoEntra
            // 
            this.btNovoEntra.BackColor = System.Drawing.Color.Red;
            this.btNovoEntra.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNovoEntra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoEntra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNovoEntra.Location = new System.Drawing.Point(194, 346);
            this.btNovoEntra.Name = "btNovoEntra";
            this.btNovoEntra.Size = new System.Drawing.Size(131, 39);
            this.btNovoEntra.TabIndex = 34;
            this.btNovoEntra.Text = "Novo";
            this.btNovoEntra.UseVisualStyleBackColor = false;
            // 
            // btCadastraEntra
            // 
            this.btCadastraEntra.BackColor = System.Drawing.Color.LightGreen;
            this.btCadastraEntra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastraEntra.Location = new System.Drawing.Point(22, 346);
            this.btCadastraEntra.Name = "btCadastraEntra";
            this.btCadastraEntra.Size = new System.Drawing.Size(131, 39);
            this.btCadastraEntra.TabIndex = 33;
            this.btCadastraEntra.Text = "Cadastrar";
            this.btCadastraEntra.UseVisualStyleBackColor = false;
            // 
            // txtQntEntrada
            // 
            this.txtQntEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntEntrada.Location = new System.Drawing.Point(17, 261);
            this.txtQntEntrada.Name = "txtQntEntrada";
            this.txtQntEntrada.Size = new System.Drawing.Size(230, 30);
            this.txtQntEntrada.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Selecione o tipo do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Informe a Quantidade ";
            // 
            // txtIDEntrada
            // 
            this.txtIDEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEntrada.Location = new System.Drawing.Point(15, 180);
            this.txtIDEntrada.Name = "txtIDEntrada";
            this.txtIDEntrada.Size = new System.Drawing.Size(232, 30);
            this.txtIDEntrada.TabIndex = 29;
            // 
            // cbTipoProdutoEntra
            // 
            this.cbTipoProdutoEntra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoProdutoEntra.FormattingEnabled = true;
            this.cbTipoProdutoEntra.Items.AddRange(new object[] {
            " ProdutoFisico",
            " Ebook",
            " Curso"});
            this.cbTipoProdutoEntra.Location = new System.Drawing.Point(12, 102);
            this.cbTipoProdutoEntra.Name = "cbTipoProdutoEntra";
            this.cbTipoProdutoEntra.Size = new System.Drawing.Size(303, 33);
            this.cbTipoProdutoEntra.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Infome o ID do produto";
            // 
            // dgvListEntrada
            // 
            this.dgvListEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.estoque});
            this.dgvListEntrada.Location = new System.Drawing.Point(365, 74);
            this.dgvListEntrada.Name = "dgvListEntrada";
            this.dgvListEntrada.RowHeadersWidth = 51;
            this.dgvListEntrada.RowTemplate.Height = 24;
            this.dgvListEntrada.Size = new System.Drawing.Size(381, 377);
            this.dgvListEntrada.TabIndex = 35;
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
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListEntrada);
            this.Controls.Add(this.btNovoEntra);
            this.Controls.Add(this.btCadastraEntra);
            this.Controls.Add(this.txtQntEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDEntrada);
            this.Controls.Add(this.cbTipoProdutoEntra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Entrada";
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNovoEntra;
        private System.Windows.Forms.Button btCadastraEntra;
        private System.Windows.Forms.TextBox txtQntEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDEntrada;
        private System.Windows.Forms.ComboBox cbTipoProdutoEntra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    }
}