using ControleEstoque1.Formulario;
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
    enum OpcaoAdi
    {
        ProdutoFisico,
        Ebook,
        Curso
    }

    public partial class Adicionar : Form
    {

        public Adicionar()
        {
            InitializeComponent();
            txtAutor.Visible = false;
            txtFrete.Visible = false;
            lbAutor.Visible = false;
            lbFrete.Visible = false;
            cbTipoProdutoAdd.DataSource = Enum.GetValues(typeof(OpcaoAdi));
        }

        private void cbTipoProdutoAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            OpcaoAdi escolha = (OpcaoAdi)cbTipoProdutoAdd.SelectedItem;

            switch (escolha)
            {
                case OpcaoAdi.ProdutoFisico:
                    txtFrete.Visible = true;
                    lbFrete.Visible = true;
                    txtAutor.Visible = false;
                    lbAutor.Visible = false;
                    break;
                case OpcaoAdi.Ebook:
                case OpcaoAdi.Curso:
                    txtAutor.Visible = true;
                    lbAutor.Visible = true;
                    txtFrete.Visible = false;
                    lbFrete.Visible = false;
                    break;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtAutor.Clear();
            txtDescricao.Clear();
            txtFrete.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            cbTipoProdutoAdd.Select();
        }

        private void btCadastra_Click(object sender, EventArgs e)
        {

            produto produtos = new produto();
            {
                produtos.Nome = txtNome.Text;
                produtos.Descricao = txtDescricao.Text;
                produtos.preco = Convert.ToDouble(txtPreco.Text);
                produtos.tipo = (OpcaoAdi)cbTipoProdutoAdd.SelectedItem;

                if(produtos.tipo == OpcaoAdi.ProdutoFisico)
                {
                    produtos.frete = Convert.ToDecimal(txtFrete.Text);
                    produtos.Autor = null;
                }
                else
                {
                    produtos.Autor = txtAutor.Text;
                    produtos.frete = null;
                }
                BancoDados.ProdutoLis.Add(produtos);

                MessageBox.Show("Produto Salvo com Sucesso!");

            }
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
