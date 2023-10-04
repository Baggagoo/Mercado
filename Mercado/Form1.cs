using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        Produtos produtos;
        List<Produtos> ListProdutos = new List<Produtos>();

        private void Form1_Load(object sender, EventArgs e)
        {

            inserirProdutos();
        }

        private void inserirProdutos()
        {
            produtos = new Produtos("Abacaxi", 759, 5, 7.98);
            ListProdutos.Add(produtos);
            produtos = new Produtos("Maçã", 950, 10, 2.23);
            ListProdutos.Add(produtos);
            produtos = new Produtos("Abacate", 523, 2, 5.43);
            ListProdutos.Add(produtos);
            produtos = new Produtos("Pêra", 812, 8, 3.87);
            ListProdutos.Add(produtos);
            produtos = new Produtos("Manga", 359, 4, 5.13);
            ListProdutos.Add(produtos);
            cbxProduto.Items.Clear();

            foreach (var produtos in ListProdutos)
            {
                cbxProduto.Items.Add(produtos.getNome());
            }
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Encontre o produto selecionado na lista de produtos
            var produtoSelecionado = ListProdutos.Find(p => p.getNome() == cbxProduto.SelectedItem.ToString());

            if (produtoSelecionado != null)
            {
                // Atualize o TextBox com o estoque do produto selecionado
                txtEstoque.Text = Convert.ToString(produtoSelecionado.getEstoque());
                txtValorUnitario.Text = Convert.ToString(produtoSelecionado.getValorUnidade());
                txtQntLevar.Text = Convert.ToString(produtoSelecionado.getQntLevar());
                txtValorTotal.Text = Convert.ToString(produtoSelecionado.getValorUnidade() * produtoSelecionado.getQntLevar());
            }
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnCheckList_Click(object sender, EventArgs e)
        {

        }
    }
}
