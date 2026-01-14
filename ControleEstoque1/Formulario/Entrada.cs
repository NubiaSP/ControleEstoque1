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
        }

        private void cbTipoProdutoEntra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcEntrada = cbTipoProdutoEntra.SelectedIndex;
            OpcaoEntrada escolhaEntrada = (OpcaoEntrada)opcEntrada;

            switch (escolhaEntrada)
            {
                case OpcaoEntrada.ProdutoFisico:
                    break;
                case OpcaoEntrada.Ebook:
                    break;
                case OpcaoEntrada.Curso:
                    break;
            }
        }

        private void btNovoEntra_Click(object sender, EventArgs e)
        {
            txtIDEntrada.Clear();
            txtQntEntrada.Clear();
            cbTipoProdutoEntra.Select();
        }
    }
}
