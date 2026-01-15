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
    enum OpcaoEntrada
    {
        ProdutoFisico,
        Ebook,
        Curso
    }
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
            cbTipoProdutoEntra.DataSource = Enum.GetValues(typeof(OpcaoRemover));

            var ResumoProdEn = BancoDados.ProdutoLis.Select(p => new
            {
                p.id,
                p.Nome,
                p.Estoque,
                p.Vendas,


            }).ToList();
            dgvListEntrada.DataSource = ResumoProdEn;

        }

        private void cbTipoProdutoEntra_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btNovoEntra_Click(object sender, EventArgs e)
        {
            txtIDEntrada.Clear();
            txtQntEntrada.Clear();
            cbTipoProdutoEntra.Select();
        }

        private void btCadastraEntra_Click(object sender, EventArgs e)
        {
            int idEntrada;
            int qntEntrada;
            if (!int.TryParse(txtIDEntrada.Text,out idEntrada))
            {
                MessageBox.Show("ID Inválido!");
                return;
            }
            if(!int.TryParse(txtIDEntrada.Text, out qntEntrada) || qntEntrada <= 0)
            {
                MessageBox.Show("ID Inválido!");
                return;
            }
            var produtoEn = BancoDados.ProdutoLis
                .FirstOrDefault(p => p.id == idEntrada);
            if (produtoEn == null)
            {
                MessageBox.Show("Produto não encontrado");
                return;

            }
            produtoEn.Estoque += qntEntrada;

            MessageBox.Show("Estoque atualizado");
        }
    }
}
