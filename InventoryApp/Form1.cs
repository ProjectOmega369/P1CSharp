using Classinventory;
namespace InventoryApp
{
    public partial class Form1 : Form
    {
        private InventoryManager inventario;
        public Form1()
        {
            InitializeComponent();
            inventario = new InventoryManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new FormNovoProduto())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var produto = inventario.AdicionarProduto(form.ProdutoCriado);
                    AtualizarLista();
                }
            }
        }

        private void AtualizarLista()
        {
            dataGridView1.DataSource = null; // limpa o DataGridView
            dataGridView1.DataSource = inventario.ListarProdutos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var produtoSelecionado = (Produto)dataGridView1.CurrentRow.DataBoundItem;

                inventario.RemoverProduto(produtoSelecionado);

                MessageBox.Show($"Produto '{produtoSelecionado.nome}' removido com sucesso.");
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var formConsulta = new FormConsulta())
            {
                if (formConsulta.ShowDialog() == DialogResult.OK && formConsulta.idConsultado.HasValue)
                {
                    int id = formConsulta.idConsultado.Value;

                    var produto = inventario.ListarProdutos().FirstOrDefault(p => p.id == id);

                    if (produto != null)
                    {
                        // Mostra só o produto consultado no DataGridView
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = new List<Produto> { produto };
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                    }
                }
            }
        }
    }
}
