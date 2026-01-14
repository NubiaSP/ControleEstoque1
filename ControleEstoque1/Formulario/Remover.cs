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
        }

        private void cbTipoProdutoRemov_SelectedIndexChanged(object sender, EventArgs e)
        {

            int opcRemov = cbTipoProdutoRemov.SelectedIndex;
            OpcaoRemover escolhaRemov = (OpcaoRemover)opcRemov;

            switch (escolhaRemov)
            {
                case OpcaoRemover.ProdutoFisico:
                    break;
                case OpcaoRemover.Ebook:
                    break;
                case OpcaoRemover.Curso:
                    break;
            }

        }

        private void btNovoRemov_Click(object sender, EventArgs e)
        {
            txtIDRemov.Clear();
            cbTipoProdutoRemov.Select();
        }
    }
}
