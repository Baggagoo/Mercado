using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    internal class Produtos
    {
        string nome;
        int estoque, qntLevar;
        double valorUnidade, valorTotal;

        public Produtos(string nome, int estoque, int qntLevar, double valorUnidade)
        {
            this.nome = nome;
            this.estoque = estoque;
            this.qntLevar = qntLevar;
            this.valorUnidade = valorUnidade;
           
        }

        public string getNome() { return nome; }
        public int getEstoque() {  return estoque; }
        public int getQntLevar() {  return qntLevar; }
        public double getValorUnidade() { return valorUnidade; }
        public double getValorTotal() { return valorTotal; }

    }
}
