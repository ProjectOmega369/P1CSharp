using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classinventory;

namespace InventoryApp
{
    public partial class FormNovoProduto : Form
    {
        public Produto ProdutoCriado { get; private set; }
        public FormNovoProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBox1.Text;
                int valor = int.Parse(textBox2.Text);
                int quantidade = int.Parse(textBox3.Text);

                ProdutoCriado = new Produto();
                ProdutoCriado.nome = nome;
                ProdutoCriado.valor = valor;
                ProdutoCriado.quantidade = quantidade;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
        }
    }
}
