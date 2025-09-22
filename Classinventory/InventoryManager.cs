using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classinventory
{

    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }

        public int quantidade { get; set; }

        public decimal valor { get; set; }
    }
    public class InventoryManager
    {
        int id = 0;
        List<Produto> produtos = new List<Produto>();


        public Produto AdicionarProduto(Produto produto)
        {
            id++;
            produto.id = id;
            produtos.Add(produto);
            return produto;
        }
        public void RemoverProduto(Produto produto)
        {
            var id = produto.id;

            if(id != 0)
            {
                produtos.Remove(produto);
                
            }
            id--;

        }

        int ConsultarProduto(int id)
        {

           var produto = produtos.FirstOrDefault(p => p.id == id);
            if (produto != null)
            {
                return produto.id; 
            }
            else
            {
                return 0;
            }
        }

        public List<Produto> ListarProdutos()
        {
            return produtos.ToList();
        }
    }
}


    
