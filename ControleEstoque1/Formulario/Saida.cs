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
    enum OpcaoSaida
    {
        ProdutoFisico,
        Ebook,
        Curso
    }
    public partial class Saida : Form
    {
        public Saida()
        {
            InitializeComponent(); 
            cbTipoProdutoSaida.DataSource = Enum.GetValues(typeof(OpcaoRemover));

            var ResumoProdEn = BancoDados.ProdutoLis.Select(p => new
            {
                p.id,
                p.Nome,
                p.Estoque,
                p.Vendas,


            }).ToList();
            dgvListSaida.DataSource = ResumoProdEn;
        }

        private void cbTipoProdutoSaida_SelectedIndexChanged(object sender, EventArgs e)
        {

            int opcSaida = cbTipoProdutoSaida.SelectedIndex;
            OpcaoSaida escolhaSaida = (OpcaoSaida)opcSaida;

            switch (escolhaSaida)
            {
                case OpcaoSaida.ProdutoFisico:
                    break;
                case OpcaoSaida.Ebook:
                    break;
                case OpcaoSaida.Curso:
                    break;
            }
        }

        private void btNovoSaida_Click(object sender, EventArgs e)
        {
            txtIDSaida.Clear();
            txtQntSaida.Clear();
            cbTipoProdutoSaida.Select();
        }

        private void btCadastraSaida_Click(object sender, EventArgs e)
        {
            int idSaida;
            int qntSaida;
            if (!int.TryParse(txtIDSaida.Text, out idSaida))
            {
                MessageBox.Show("ID Inválido!");
                return;
            }
            if (!int.TryParse(txtIDSaida.Text, out qntSaida) || qntSaida <= 0)
            {
                MessageBox.Show("ID Inválido!");
                return;
            }
            var produtoEn = BancoDados.ProdutoLis
                .FirstOrDefault(p => p.id == idSaida);
            if (produtoEn == null)
            {
                MessageBox.Show("Produto não encontrado");
                return;

            }
            if (produtoEn.Estoque < qntSaida)
            {
                MessageBox.Show("Estoque insuficiente");
                return;
            }
            produtoEn.Estoque -= qntSaida;

            MessageBox.Show("Estoque atualizado");
        }
    }
}
