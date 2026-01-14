using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoque1.Formulario;

namespace ControleEstoque1.Formulario
{
    internal class produto
    {
        private static int contadorID = 1;
        public int id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double preco { get; set; }
        public decimal? frete { get; set; }
        public string Autor { get; set; }
        public OpcaoAdi tipo { get; set; }
        public int? Estoque { get; set; }
        public int? Vendas { get; set; }


        public produto()
        {
            id = contadorID;
            contadorID++;
        }
        
    }
}
