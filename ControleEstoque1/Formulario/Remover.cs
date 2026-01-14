using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque1.Formulario
{
    enum OpcaoRemover
    {
        ProdutoFisico,
        Ebook,
        Curso
    }
    public partial class Remover : Form
    {
        public Remover()
        {
            InitializeComponent();
            cbTipoProdutoRemov.DataSource = Enum.GetValues(typeof(OpcaoRemover));
   
                var ResumoProduto = BancoDados.ProdutoLis.Select(p => new
                {
                    p.id,
                    p.Nome,
                    p.Estoque,
                    p.Vendas,


                }).ToList();
                dgvListRemov.DataSource = ResumoProduto;
           
        }

        private void cbTipoProdutoRemov_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            OpcaoRemover escolhaRemov = (OpcaoRemover)cbTipoProdutoRemov.SelectedItem;

            switch (escolhaRemov)
            {
                case OpcaoRemover.ProdutoFisico:

                    DialogResult respostaPf = MessageBox.Show
                    ("Deseja mesmo excluir um produto?",
                    "Confirmação", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respostaPf == DialogResult.No)
                    {
                        VoltarTelaInicial();
                    }

                    break;
                case OpcaoRemover.Ebook:

                    DialogResult respostaEb = MessageBox.Show
                    ("Deseja mesmo excluir um Ebook?",
                    "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respostaEb == DialogResult.No)
                    {
                        VoltarTelaInicial();
                    }

                    break;
                case OpcaoRemover.Curso:

                    DialogResult respostaCs = MessageBox.Show
                    ("Deseja mesmo excluir um Curso?",
                    "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respostaCs == DialogResult.No)
                    {
                        VoltarTelaInicial();
                    }

                    break;
            }

        }

        private void btNovoRemov_Click(object sender, EventArgs e)
        {
            txtIDRemov.Clear();
            cbTipoProdutoRemov.Select();
        }

        private void VoltarTelaInicial()
        {
            this.Hide(); //escolhe a tela inical 
            Form1 formPricipal = new Form1();

            formPricipal.Show();
        }
    }
}
