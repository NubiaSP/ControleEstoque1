using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoque1.Formulario;

namespace ControleEstoque1
{
    enum OpcaoInicio
    {
        Listagem,
        Adicionar,
        Remover,
        Entrada,
        Saida
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOpcaoInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcOperacao = cbOpcaoInicio.SelectedIndex;

            OpcaoInicio escolha = (OpcaoInicio)opcOperacao;

            switch (escolha)
            {
                case OpcaoInicio.Listagem:
                    Listagem formLis = new Listagem();
                    formLis.ShowDialog();
                    break;
                case OpcaoInicio.Adicionar:
                    Adicionar formAdi = new Adicionar();
                    formAdi.ShowDialog();
                    break;
                case OpcaoInicio.Remover:
                    Remover formRem = new Remover();
                    formRem.ShowDialog();
                    break;
                case OpcaoInicio.Entrada:
                    Entrada formEnt = new Entrada();
                    formEnt.ShowDialog();
                    break;            
                case OpcaoInicio.Saida:
                    Saida formSai = new Saida();
                    formSai.ShowDialog();
                    break;
            }
        }
    }
}
