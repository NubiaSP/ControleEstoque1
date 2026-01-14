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
        }

        private void cbTipoProdutoAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcCadastro = cbTipoProdutoAdd.SelectedIndex;
            OpcaoAdi escolha = (OpcaoAdi)opcCadastro;

            switch (escolha)
            {
                case OpcaoAdi.ProdutoFisico:
                    txtFrete.Visible = true;
                    lbFrete.Visible = true;
                    break;
                case OpcaoAdi.Ebook:
                    txtAutor.Visible = true;
                    lbAutor.Visible = true;
                    break;
                case OpcaoAdi.Curso:
                    txtAutor.Visible = true;
                    lbAutor.Visible = true;
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
    }
}
