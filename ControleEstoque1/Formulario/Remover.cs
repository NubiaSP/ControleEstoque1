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

        private void btRemov_Click(object sender, EventArgs e)
        {
            int idRemov = Convert.ToInt32(txtIDRemov.Text);
            BancoDados.ProdutoLis.RemoveAt(idRemov - 1);
            MessageBox.Show("removido");
        }
    }
}
