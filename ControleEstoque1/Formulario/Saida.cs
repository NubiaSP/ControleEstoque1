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
    }
}
